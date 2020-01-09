using System;

namespace GlobalStoreApp.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string TitleRO { get; set; }
        public string TitleRU { get; set; }
        public string TitleEN { get; set; }

        public int PricePromo { get; set; }
        public int Price { get; set; }
        public int PriceAngro { get; set; }
        public int PricePromoAngro { get; set; }

        public int PriceAngroPromo { get; set; }
        public int MinimalPrice { get; set; }
        public string DescriptionRO { get; set; }
        public string DescriptionRU { get; set; }
        public string DescriptionEN { get; set; }
        public int Stoc { get; set; }
        public int QtySet { get; set; }
        public int QtyBox { get; set; }
        public string Model { get; set; }
        public string ImageTitle { get; set; }
        public int StocRetail { get; set; }

        public int Cod { get; set; }
        public int ParentCod { get; set; }
        public string Brand { get; set; }
        public int UnitSalesSet { get; set; }
        public int UnitSalesBox { get; set; }
        public int Discount { get; set; }
        public string Country { get; set; }

    }
}
