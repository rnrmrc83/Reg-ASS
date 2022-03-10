using System;
using System.Collections.Generic;

namespace ShopReg.Models
{
    public partial class VProductSupplier
    {
        public string? Category_Name { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public string? State { get; set; }
        public int? ShipTime { get; set; }
        public string Id { get; set; } = null!;
        public string? Description { get; set; }
        public int? QtyAvailable { get; set; }
    }
}
