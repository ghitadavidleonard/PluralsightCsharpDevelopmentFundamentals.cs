using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
