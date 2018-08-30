using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Vote.Common;

namespace Vote.App.Infrastructure.Filters
{
    public class RedirectLoggedIn : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var isLoggedIn = context.HttpContext.User.IsInRole(RoleType.Manager);

            if (isLoggedIn)
            {
                var routeValue = new RouteValueDictionary(new { action = "Index", controller = "Activities", area = "Manager" });

                context.Result = new RedirectToRouteResult(routeValue);
            }
        }
    }
}