using ECommerce.Common.Enums;
using ECommerce.Entity.Interface;
using System;
using System.Collections.Generic;

namespace ECommerce.Entity
{
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string PaymentId { get; set; }
        public string ConversationId { get; set; }
        public double ShippingPrice { get; set; } = 0;
        public double? TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

    }


}