﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCalendar.Controllers
{
    public class CalendarController : Controller
    {
        DateTime dt1 = new DateTime();

        public ActionResult Month()
        {
            return View();
        }
    }
}