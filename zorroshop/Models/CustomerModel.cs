using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zorroshop.Models
{
    public class CustomerModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string address { get; set; }
        public int discount { get; set; }

    }
}