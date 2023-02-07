using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class AppUser : BaseEntity
    {
        public AppUser()
        {
            Reviews = new List<Review>();
            Orders = new List<Order>();
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string? Address { get; set; }
        public List<Review> Reviews { get; set; }
        public int? CardId { get; set; }
        public Card? Card { get; set; }
        public int? SellerId { get; set; }
        public Seller? Seller { get; set; }
        public List<Order> Orders { get; set; }
    }
}
