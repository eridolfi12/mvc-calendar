using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MvcCalendar.Models
{

    public class CalData
    {
        public Item[] Items { get; set; }
    }

    public class Item
    {
        public float Score { get; set; }
        public string ItemName { get; set; }
        public string ImageURL { get; set; }
        public string CustomURL { get; set; }
        public string Price { get; set; }
        public string SalePrice { get; set; }
        public bool IsOnSale { get; set; }
        public string BestFragment { get; set; }
        public CourseFields CourseFields { get; set; }
    }

    public class CourseFields
    {
        public string name { get; set; }
        public string image { get; set; }
        public string url_detail { get; set; }
        public string price_retail { get; set; }
        public string price_sale { get; set; }
        public string sku { get; set; }
        public string category { get; set; }
        public string city { get; set; }
        public string totalcredits { get; set; }
        public string it { get; set; }
        public DateTime startdatetime { get; set; }
        public DateTime enddatetime { get; set; }
        public string startdate { get; set; }
        public string pbinumber { get; set; }
        public string startdateasnumber { get; set; }
        public string totalsubstantivecredits { get; set; }
        public string totalethicscredits { get; set; }
    }

}