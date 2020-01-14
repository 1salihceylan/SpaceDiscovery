using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceDiscoveryApi.LogDependencyInjection
{
    class Processor
    {
        ILogger logger = null;

        public Processor(ILogger _logger)
        {
            logger = _logger;
        }
        public void Process()
        {
            logger.WriteLog("Log Text");
            
        }
    }
}