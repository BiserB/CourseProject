using Microsoft.AspNetCore.Mvc;
using Vote.Common;

namespace Vote.App.Areas.Participant.Controllers
{
    [Area(RoleType.Participant)]
    public abstract class BaseParticipantController : Controller
    {
        protected readonly string BaseUrl = "/main/home/index";
    }
}