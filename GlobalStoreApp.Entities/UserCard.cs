using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalStoreApp.Entities
{
    public class UserCard
    {
        public int ID { get; set;}
        public int? UserID { get; set; }
        public string CardNumber { get; set; }
        public string PaymentMode { get; set; }
        public bool IsDeleted { get; set; }
        public virtual User UserEntity { get; set; }
    }
}
