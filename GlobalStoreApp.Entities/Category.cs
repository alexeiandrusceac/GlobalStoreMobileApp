using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalStoreApp.Entities
{
    public class Category
    {
        public int Cod { get; set; }
        public int ParentCod { get; set; }
        public string DescriptionRO { get; set; }
        public string DescriptionRU { get; set; }
        public string DescriptionEN { get; set; }
        public string TitleRU { get; set; }
        public string TitleEN { get; set; }
        public string TitleRO { get; set; }
        public int ID { get; set; }
        public string ImageTitle { get; set; }
        public int IsActive { get; set; }
        public int OnSite { get; set; }

    }
}
