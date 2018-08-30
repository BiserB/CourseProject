using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vote.Common;
using Vote.Data;
using Vote.Entities;

namespace Vote.App.Areas.Participant.Controllers
{
    [Area(RoleType.Participant)]
    public abstract class BaseParticipantController : Controller
    {
        protected readonly string BaseUrl = "/home/index";
    }
}