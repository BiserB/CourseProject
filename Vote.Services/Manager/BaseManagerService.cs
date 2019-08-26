using AutoMapper;
using System;
using System.Linq;
using Vote.Data;
using Vote.Entities;

namespace Vote.Services.Manager
{
    public abstract class BaseManagerService
    {
        protected VoteDbContext db;
        protected IMapper mapper;
        private Random random;

        protected BaseManagerService(VoteDbContext db,
                                    IMapper mapper)

        {
            this.db = db;
            this.mapper = mapper;
            this.random = new Random();
        }

        protected string GetEventCode()
        {
            var codes = this.db.Events.Select(e => e.Code).ToList();

            var newCode = this.GenerateCode();

            while (codes.Contains(newCode))
            {
                newCode = this.GenerateCode();
            }

            return newCode;
        }

        protected Event GetDbEvent(int id, string userId)
        {
            var dbEvent = this.db.Events
                              .FirstOrDefault(e => e.Id == id &&
                                                   e.CreatorId == userId &&
                                                   e.IsDeleted == false);

            return dbEvent;
        }

        private string GenerateCode()
        {
            char[] code = new char[5];
            char[] letters = "abcdefghijkmnopqrstuvwxyz".ToCharArray();
            char[] digits = "0123456789".ToCharArray();

            int lettersNum = letters.Length;
            int digitsNum = digits.Length;

            int index = random.Next(0, lettersNum - 1);

            code[0] = letters[index];

            for (int i = 1; i <= 4; i++)
            {
                index = random.Next(0, digitsNum - 1);

                code[i] = digits[index];
            }

            string result = new string(code);

            return result;
        }

        protected bool IsCodeOccupied(string code)
        {
            bool isOccupied = this.db.Events.Any(e => e.Code == code);

            return isOccupied;
        }
    }
}