using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalStoreApp.Entities
{
    public class UserCart
    {
        public int ID { get; set; }
        public int? UserID { get; set; }
        public int? ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDateTime { get; set;}
        public DateTime UpdatedDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public virtual User UserEntity { get; set; }
        public virtual Product ProductEntity { get; set; }
    }
}
