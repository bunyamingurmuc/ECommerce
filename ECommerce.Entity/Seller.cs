using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class Seller:BaseEntity
    {
        public Seller()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<Category> Categories{ get; set; }
        public List<Product> Products { get; set; }
    }
}
