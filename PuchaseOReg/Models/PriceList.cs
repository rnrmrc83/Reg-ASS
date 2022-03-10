using System;
using System.Collections.Generic;

namespace ShopReg.Models

{
    public partial class PriceList
    {
        public int Id { get; set; }
        public string IdProduct { get; set; } = null!;
        public string? CodeList { get; set; }
        public string? IdDiscountType { get; set; }
        public decimal? Price { get; set; }
        public int? LowLimit { get; set; }
        public int? HighLimit { get; set; }
        public decimal? ValueLimit { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? Discontinued { get; set; }

        public virtual Product IdProductNavigation { get; set; } = null!;
    }
}
