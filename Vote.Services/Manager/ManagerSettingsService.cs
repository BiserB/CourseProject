using AutoMapper;
using System.Linq;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Services.Manager.Interfaces;

namespace Vote.Services.Manager
{
    public class ManagerSettingsService : IManagerSettingsService
    {
        private VoteDbContext db;
        private IMapper mapper;

        public ManagerSettingsService(VoteDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
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

        public bool SaveEventChanges(EventSetupModel model, string userId)
        {
            var dbEvent = this.db.Events
                .FirstOrDefault(e => e.Id == model.Id && e.CreatorId == userId);

            if (dbEvent == null)
            {
                return false;
            }

            dbEvent.Code = model.Code;
            dbEvent.Title = model.Title;
            dbEvent.StartDate = model.StartDate;
            dbEvent.EndDate = model.EndDate;
            dbEvent.IsClosed = model.IsClosed;
            dbEvent.AnonymousAllowed = model.AnonymousAllowed;

            db.SaveChanges();

            return true;
        }
    }
}