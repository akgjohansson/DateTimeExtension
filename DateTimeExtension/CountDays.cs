using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExtension
{
    public static class CountDays
    {
        public static int GetTotalWeekDays(DateTime today, DateTime endDay)
        {
            int totalWeekDays = 0;
            int totalDays = Convert.ToInt32(Math.Round((endDay - today).TotalDays));

            DateTime nextDay = Convert.ToDateTime(today.ToShortDateString());
            for (int i = 0; i <= totalDays; i++)
            {
                nextDay = nextDay.AddDays(1);
                if (nextDay.DayOfWeek != DayOfWeek.Sunday && nextDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    totalWeekDays++;
                }
            }
            return totalWeekDays;
        }
    }
}
