using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;

namespace Vote.Services.Manager
{
    public class ManagerSettingsService : BaseManagerService, IManagerSettingsService
    {
        private IHostingEnvironment hostingEnvironment;

        public ManagerSettingsService(VoteDbContext db, IMapper mapper, IHostingEnvironment env)
                            : base(db, mapper)
        {
            this.hostingEnvironment = env;
        }

        public EventSetupModel GetEventSetupModel(int eventId, string userId)
        {
            var dbEvent = this.db.Events
                .FirstOrDefault(e => e.Id == eventId && e.IsDeleted == false);

            if (dbEvent == null || userId != dbEvent.CreatorId)
            {
                return null;
            }

            var model = this.mapper.Map<EventSetupModel>(dbEvent);

            return model;
        }

        public Event GetEvent(EventSetupModel model, string userId)
        {
            var dbEvent = this.GetDbEvent(model.Id, userId);

            return dbEvent;
        }

        public bool SaveEventChanges(EventSetupModel model, Event dbEvent)
        {   
            if (dbEvent.Code != model.Code)
            {
                var codeIsOccupied = this.db.Events.Any(e => e.Code == model.Code && e.IsDeleted == false);

                if (codeIsOccupied)
                {
                    return false;
                }
            }

            dbEvent.Code = model.Code;
            dbEvent.Title = model.Title;
            dbEvent.StartDate = model.StartDate;
            dbEvent.EndDate = model.EndDate;
            dbEvent.IsClosed = model.IsClosed;
            dbEvent.IsModerated = model.IsModerated;
            dbEvent.AnonymousAllowed = model.AnonymousAllowed;

            db.SaveChanges();

            return true;
        }

        public async Task<bool> UploadLogo(IFormFile file, string userId)
        {
            if (file.Length > 0)
            {
                var newFileName = userId + Path.GetExtension(file.FileName);

                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");

                var filePath = Path.Combine(uploads, newFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                var user = this.db.Users.Find(userId);

                user.HasLogo = true;

                this.db.SaveChanges();

                return true;
            }
            return false;
        }

        //private string GetUniqueFileName(string fileName)
        //{
        //    fileName = Path.GetFileName(fileName);

        //    return Path.GetFileNameWithoutExtension(fileName)
        //              + "_"
        //              + Guid.NewGuid().ToString().Substring(0, 4)
        //              + Path.GetExtension(fileName);
        //}
    }
}