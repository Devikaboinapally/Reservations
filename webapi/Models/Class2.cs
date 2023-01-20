using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Class2
    {
        public int Sl_No { get; set; }
        public string Hotel { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public string Type { get; set; }
        public Nullable<int> Guests { get; set; }
        public Nullable<int> Price { get; set; }
    }
}