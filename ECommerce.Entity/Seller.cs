using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class Seller : BaseEntity
    {
        public Seller()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
            AppUsers = new List<AppUser>();
            Orders = new List<Order>();
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
