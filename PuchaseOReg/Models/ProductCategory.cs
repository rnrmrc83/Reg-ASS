using System;
using System.Collections.Generic;

namespace ShopReg.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Category_Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
