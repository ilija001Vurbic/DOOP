using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_DOOP
{
    class ConsoleLogger : ILogger
    {
        public void Log(ILoggable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}
