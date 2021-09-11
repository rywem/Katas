using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.Ardalis.NSFileLogger
{
    public class DefaultFileNameStrategy : IFileNameStrategy
    {
        public string GetFileName(DateTime currentTime)
        {
            if (currentTime.DayOfWeek == DayOfWeek.Saturday || currentTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return "weekend.txt";
            }
            string todayString = currentTime.ToString("yyyy-MM-dd");
            return $"log{todayString}.txt";
        }
    }
}
