using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class Review : BaseEntity
    {
        public double Rate { get; set; }
        public string Description { get; set; }
        public int? AppUserId { get; set; }
        public int? ProductId { get; set; }
        public AppUser? AppUser { get; set; }
        public Product? Product { get; set; }
    }
}
