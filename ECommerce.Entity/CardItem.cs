using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class CardItem : BaseEntity
    {
        public int Quantity { get; set; }
        public int? CardId { get; set; }
        public Card? Card { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public double Amount { get; set; }
        public int RemoveCount { get; set; }

        public double Sum()
        {
            return Product.Price * Quantity;
        }
    }
}
