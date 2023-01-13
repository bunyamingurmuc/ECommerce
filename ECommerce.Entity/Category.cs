using ECommerce.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public int? SellerId { get; set; }
        public Seller? Seller { get; set; }
    }
}
