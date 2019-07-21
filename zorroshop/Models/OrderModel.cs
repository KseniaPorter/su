using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zorroshop.Models
{
    public class OrderModel
    {
        public Guid id { get; set; }
        public Guid CUSTOMER_ID { get; set; }
        public DateTime ODER_DATE { get; set; }
        public DateTime SHIPMENT_DATE { get; set; }
        public int ORDER_NUMBER { get; set; }
        public string STATUS { get; set; }


    }
}