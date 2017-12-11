using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCalendar.Models;
using System.Text;

namespace MvcCalendar.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult Month()
        {
            var course = new Courses();

            return View();
        }

        public ActionResult TestJSON()
        {
            string text = "";
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    var json2 = webClient.DownloadString("http://manage.hawksearch.com/sites/pbi/?&mpp=200&hawkoutput=custom&hawkitemlist=json");
                    return Json(json2, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception e)
            {
                text = "error";
            }
            return Json(new { json = text });
        }
    }
}