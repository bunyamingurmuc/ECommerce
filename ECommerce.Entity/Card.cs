using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class Card : BaseEntity
    {
        public Card()
        {
            CardItems = new List<CardItem>();
        }

        public double? TotalPrice { get; set; }
        public int Discount { get; set; } = 0;
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
        public List<CardItem> CardItems { get; set; }

    }
}
