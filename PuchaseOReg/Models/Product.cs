using System;
using System.Collections.Generic;

namespace ShopReg.Models

{
    public partial class Product
    {
        public Product()
        {
            PriceLists = new HashSet<PriceList>();
        }

        public string Id { get; set; } = null!;
        public string? Description { get; set; }
        public int IdSupplier { get; set; }
        public int? IdCategory { get; set; }
        public int? QtyAvailable { get; set; }
        public decimal? PriceUnit { get; set; }
        public int? ShippingMinDay { get; set; }

        public virtual ProductCategory? IdCategoryNavigation { get; set; }
        public virtual Supplier IdSupplierNavigation { get; set; } = null!;
        public virtual ICollection<PriceList> PriceLists { get; set; }
    }
}
