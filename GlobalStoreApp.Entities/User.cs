using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalStoreApp.Entities
{
    public class User
    {
         public int ID { get; set; }

         public string Name { get; set; }   
         public string Email { get; set; }
        public string Password { get; set; }
        public int isActive { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set; }
        public virtual ICollection<UserCard> UserCards { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<UserCart> UserCart { get; set; }


    }


}
