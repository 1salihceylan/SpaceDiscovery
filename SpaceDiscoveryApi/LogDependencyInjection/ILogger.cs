using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceDiscoveryApi.LogDependencyInjection
{
    interface ILogger
    {
        void WriteLog(string message);
    }
}
