using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zorroshop.Models
{
    public class OrderElemModel
    {
        public Guid ID { get; set; }
        public Guid ORDER_ID { get; set; }
        public Guid ITEM_ID { get; set; }
        public int ITEMS_COUNT { get; set; }
        public double ITEM_PRICE { get; set; }
    }
}