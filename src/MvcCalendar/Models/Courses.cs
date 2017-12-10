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
    }
}