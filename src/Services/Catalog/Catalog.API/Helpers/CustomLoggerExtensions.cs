using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Helpers
{
    public static class CustomLoggerExtensions 
    {
        public static void CustomLogInformation(this ILogger logger)
        {
            logger.LogInformation("Constractor Creating");
        }
    }
}
