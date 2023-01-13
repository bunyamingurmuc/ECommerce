using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class Product:BaseEntity
    {
        public Product()
        {
            Reviews = new List<Review>();
            Products= new List<Product>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public double Ratings { get; set; }
        public bool IsStock { get; set; }
        public bool IsTop { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew{ get; set; }
        public bool IsSold { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Review> Reviews { get; set; }
        public int? SellerId { get; set; }
        public Seller? Seller { get; set; }
        public List<Product>? Products { get; set; }
    }
}
