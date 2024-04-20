using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class DateService
    {
        public static string GetDay(string date)
        {
            DateTime toDate;
            CultureInfo obj = new CultureInfo("ru-RU");
            toDate = DateTime.Parse(date);
            return obj.TextInfo.ToTitleCase(obj.DateTimeFormat.GetDayName(toDate.DayOfWeek));
        }
        public static int GetDaysSpan(int day, int month, int year)
        {
            DateTime newDate;
            DateTime today = DateTime.Today;

            DateTime.TryParse($"{day}/{month}/{year}", out  newDate);
            
            return (newDate - today).Days;
        }
    }
}
