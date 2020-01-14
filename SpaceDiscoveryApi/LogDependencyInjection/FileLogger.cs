using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SpaceDiscoveryApi.LogDependencyInjection
{
    class FileLogger : ILogger
    {
        public void WriteLog(string message)
        {
            //Console.WriteLine(String.Format("FileLogger : {0}", message));

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }

        }
    }
}