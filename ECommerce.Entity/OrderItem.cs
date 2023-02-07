using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class OrderItem : BaseEntity
    {

        public double? ProductPrice { get; set; }
        public int? ProductDiscount { get; set; }
        public string? ProductName { get; set; }
        public string? ImageUrl { get; set; }
        public int Quantity { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}