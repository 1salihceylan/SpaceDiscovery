using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceDiscoveryApi.LogDependencyInjection
{
    class DBLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(String.Format("DBLogger : {0}", message));
        }
    }
}