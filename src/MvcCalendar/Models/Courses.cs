using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCalendar.Models
{
    public class Courses
    {
        public string CourseTitle { get; set; }
        public string SessionUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateTime Now => DateTime.Today;
        public DateTime FirstDayOfMonth => new DateTime(Now.Year, Now.Month, 1);
        public int DayOfWeekInt => (int)FirstDayOfMonth.DayOfWeek;
        public string MonthText => Now.ToString("MMMM");
        public int MonthInt => Now.Month;
        public int Year => Now.Year;
        public int DaysInMonth => DateTime.DaysInMonth(Year, MonthInt);
        public int RowCount => DaysInMonth / 7;
    }

}