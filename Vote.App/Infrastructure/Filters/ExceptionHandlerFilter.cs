using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.App.Infrastructure.Extensions;
using Vote.Common;

namespace Vote.App.Infrastructure.Filters
{
    public class ExceptionHandlerFilter : IExceptionFilter
    {
        private readonly ILogger<ExceptionHandlerFilter> logger;

        public ExceptionHandlerFilter(ILogger<ExceptionHandlerFilter> logger)
        {
            this.logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                context.ExceptionHandled = true;

                var type = context.Exception.GetType().Name;

                var stack = context.Exception.StackTrace;

                var exceptionMsg = $"Unhandled EXCEPTION: {type} / {stack}";

                this.logger.LogError(exceptionMsg);

                this.logger.LogToFile(VoteConstants.VoteLogPath, LogLevel.Error, exceptionMsg);

                context.Result = new LocalRedirectResult("/home/index");
            }
        }
    }
}
