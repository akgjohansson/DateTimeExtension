using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExtension
{
    public class TimeZones
    {
        public static int GetTimeDifference()
        {
            return DateTime.Now.ToLocalTime().Hour - DateTime.Now.ToUniversalTime().Hour;
        }
    }
}
