using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zorroshop.Models
{
    public class ItemModel
    {
        public Guid ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public double PRICE { get; set; }
        public string CATEGORY { get; set; }
    }
}