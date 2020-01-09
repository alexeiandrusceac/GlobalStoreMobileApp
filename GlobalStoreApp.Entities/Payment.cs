using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalStoreApp.Entities
{
    public class Payment
    {
        public int ID { get; set; }
        public string PaymentMode { get; set; }
        public string CardTypeIcon { get; set; }
        public bool IsDeleted { get; set; }
    }
}
