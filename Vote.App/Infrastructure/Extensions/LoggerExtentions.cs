using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Vote.Common;

namespace Vote.App.Infrastructure.Extensions
{
    public static class LoggerExtentions
    {
        public static bool LogToFile(this ILogger logger, string filePath, LogLevel logLevel, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return false;
            }

            var msg = $"{DateTime.Now} : {logLevel.ToString()}: {message}{Environment.NewLine}";

            try
            {
                string execPath = Assembly.GetExecutingAssembly().Location;

                string basePath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(execPath), VoteConstants.PathCorrection));

                string fullPath = Path.Combine(basePath, filePath);

                File.AppendAllText(fullPath, msg);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
