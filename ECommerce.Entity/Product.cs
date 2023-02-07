using System.Security.AccessControl;
using ECommerce.Common.Enums;
using ECommerce.Entity.Interface;

namespace ECommerce.Entity
{
    public class Product : BaseEntity
    {
        public Product()
        {
            OrderItems = new List<OrderItem>();
            Reviews = new List<Review>();
            Images = new List<Image>();
            CardItems = new List<CardItem>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public bool IsStock { get; set; } = true;
        public bool IsNew { get; set; }
        public bool IsTop { get; set; }
        public double Price { get; set; }
        public int? Discount { get; set; } = 0;
        public double? SalePrice { get; set; }
        public double? Ratings { get; set; } = 0;
        public bool? IsHomeProduct { get; set; } = false;
        public int? SalesQuantity { get; set; } = 0;
        public int? RemoveCount { get; set; } = 0;
        public Unit? Unit { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Review>? Reviews { get; set; }
        public int? SellerId { get; set; }
        public Seller? Seller { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        public List<Image>? Images { get; set; }
        public List<CardItem>? CardItems { get; set; }

    }
}
