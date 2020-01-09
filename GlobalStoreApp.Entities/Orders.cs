using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalStoreApp.Entities
{
    public  class Orders
    {
        public int ID { get; set; }
        public int OrderNR { get; set; }
        public int? UserID { get; set; }
        public int? ProductID { get; set; }
        public int Quantity { get; set; }
        public User UserEntity { get; set; }
        public virtual Product Product { get; set; }
    }
}
