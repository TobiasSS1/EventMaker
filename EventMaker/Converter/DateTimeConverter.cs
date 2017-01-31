using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Converter
{
    class DateTimeConverter
    {


        public static DateTime DateTimeOffsetAndTimeSetToDateTime(DateTimeOffset Date, TimeSpan Time)
        {
            return new DateTime(Date.Year, Date.Month, Date.Day, Time.Hours, Time.Minutes, 0);
        }
    }
    
}
