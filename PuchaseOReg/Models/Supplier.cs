using System;
using System.Collections.Generic;

namespace ShopReg.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string Mobile { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
