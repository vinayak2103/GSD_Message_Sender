using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSD_Message_Sender.Models
{
    public class WhatsAppMessageModel
    {
        public string Date { get; set; }
        public string Item { get; set; }
        public string Weight { get; set; }
        public string Rate { get; set; }
        public string Location { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }
        public string PhoneNumber { get; set; }
        public string Remark { get; set; }
        public string BrokerName { get; set; }
    }
}