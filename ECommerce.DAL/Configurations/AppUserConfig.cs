using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Common.Enums;
using ECommerce.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DAL.Configurations
{
   

    public class SellerConfig : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasData(new List<Seller>()
            {
                new Seller() {Id = 1,Password = "1",Email = "1",Name = "seller1", SurName = "seller12" },
                new Seller() {Id = 2,Password = "2",Email = "2",Name = "seller2", SurName = "seller122" }
            });
        }
    }

   
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            
            builder.HasData(new List<Product>()
            {
                new Product() { Id = 1,Name  = "product1",Description = "prodcu1",Price = 2000,SalePrice = 1800,Ratings = 4.2,StockCount = 2,IsStock = true,IsHomeProduct = true,SalesQuantity = 5,RemoveCount = 2,Discount = 15,CategoryId = 1,SellerId = 1,},
                new Product() { Id = 2,Name  = "product2",Description = "prodcu2",Price = 5000,SalePrice = 1800,Ratings = 3.2,StockCount = 25,IsStock = true,IsHomeProduct = true,SalesQuantity = 5,RemoveCount = 12,Discount = 20,CategoryId = 1,SellerId = 1,},
                new Product() { Id = 3,Name  = "product3",Description = "prodcu3",Price = 6000,SalePrice = 1800,Ratings = 5.2,StockCount = 100,IsStock = true,IsHomeProduct = true,SalesQuantity = 100,RemoveCount = 10,Discount = 0,CategoryId = 1,SellerId = 1,},
                new Product() { Id = 4,Name  = "product4",Description = "prodcu4",Price = 2800,SalePrice = 1800,Ratings = 9.2,StockCount = 15,IsStock = true,IsHomeProduct = true,SalesQuantity = 21,RemoveCount = 15,Discount = 0,CategoryId = 1,SellerId = 1,},
                new Product() { Id = 5,Name  = "product5",Description = "prodcu5",Price = 4500,SalePrice = 1800,Ratings = 6.2,StockCount = 10,IsStock = true,IsHomeProduct = true,SalesQuantity = 25,RemoveCount = 2,Discount = 15,CategoryId = 2,SellerId = 1,},
                new Product() { Id = 6,Name  = "product6",Description = "prodcu6",Price = 22500,SalePrice = 1800,Ratings = 2.2,StockCount = 9,IsStock = true,IsHomeProduct = true,SalesQuantity = 1100,RemoveCount = 3,Discount = 25,CategoryId = 2,SellerId = 1,},
                new Product() { Id = 7,Name  = "product7",Description = "prodcu7",Price = 2200,SalePrice = 1800,Ratings = 5.2,StockCount = 65,IsStock = true,IsHomeProduct = true,SalesQuantity = 60,RemoveCount = 5,Discount = 40,CategoryId = 2,SellerId = 1,},
                new Product() { Id = 8,Name  = "product8",Description = "prodcu8",Price = 6500,SalePrice = 1800,Ratings = 5.5,StockCount = 1,IsStock = true,IsHomeProduct = true,SalesQuantity = 550,RemoveCount = 6,Discount = 13,CategoryId = 2,SellerId = 1,},
                new Product() { Id = 9,Name  = "product9",Description = "prodcu9",Price = 7800,SalePrice = 1800,Ratings = 3.1,StockCount = 0,IsStock = false,IsHomeProduct = true,SalesQuantity = 25,RemoveCount = 1,Discount = 17,CategoryId = 2,SellerId = 1,},
                new Product() { Id =10,Name  = "product10",Description = "prodc10u",Price = 15800,SalePrice = 1800,Ratings = 3.8,StockCount = 65,IsStock = true,IsHomeProduct = true,SalesQuantity = 1000,RemoveCount = 0,Discount = 7,CategoryId = 2,SellerId = 1,},
            });
        }
    }
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(new List<Review>()
            {
                new Review() {Id = 1, Description = "review",Rate = 2,ProductId = 1,AppUserId = 1,},
                new Review() {Id = 2, Description = "review",Rate = 2,ProductId = 2,AppUserId = 1,},
                new Review() {Id = 3, Description = "review",Rate = 2,ProductId = 3,AppUserId = 1,},
                new Review() {Id = 4, Description = "review",Rate = 2,ProductId = 4,AppUserId = 1,},
                new Review() {Id = 5, Description = "review",Rate = 2,ProductId = 5,AppUserId = 1,},
                new Review() {Id = 6, Description = "review",Rate = 2,ProductId = 6,AppUserId = 1,},
                new Review() {Id = 7, Description = "review",Rate = 2,ProductId = 7,AppUserId = 1,},
                new Review() {Id = 8, Description = "review",Rate = 2,ProductId = 8,AppUserId = 1,},
                new Review() {Id = 9, Description = "review",Rate = 2,ProductId = 9,AppUserId = 1,},
                new Review() {Id =10, Description = "review",Rate = 2,ProductId =10,AppUserId = 1,},
            });
        }
    }

    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(new List<AppUser>()
            {
                new AppUser() {Id = 1,Email = "email",Password = "1",Name = "dasd",SurName = "dasdas",Address = "adress",CardId = 1,SellerId = 1,}
            });
        }
    }



    public class CardConfig : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(new List<Card>()
            {
                new Card() {Id = 1,TotalPrice = 2000,Discount = 15,AppUserId = 1}
            });
        }
    }

    public class CardItemConfig : IEntityTypeConfiguration<CardItem>
    {
        public void Configure(EntityTypeBuilder<CardItem> builder)
        {
            builder.HasData(new List<CardItem>()
            {
                new CardItem() {Id = 1,Quantity = 2,CardId = 1,ProductId = 1,Amount = 12,RemoveCount = 2},
                new CardItem() {Id = 2,Quantity = 3,CardId = 1,ProductId = 2,Amount = 12,RemoveCount = 2},
                new CardItem() {Id = 3,Quantity = 1,CardId = 1,ProductId = 3,Amount = 12,RemoveCount = 2},
                new CardItem() {Id = 4,Quantity = 4,CardId = 1,ProductId = 4,Amount = 12,RemoveCount = 2},
            });
        }
    }

    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new List<Order>()
            {
              new Order() {Id = 1,OrderNumber = "A5845DS1",OrderDate = DateTime.Now.AddDays(-1),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2520,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 2,OrderNumber = "A5845DS2",OrderDate = DateTime.Now.AddDays(-2),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2120,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 3,OrderNumber = "A5845DS3",OrderDate = DateTime.Now.AddDays(-3),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 220,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 4,OrderNumber = "A5845DS4",OrderDate = DateTime.Now.AddDays(-4),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 4520,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 5,OrderNumber = "A5845DS5",OrderDate = DateTime.Now.AddDays(-1),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2820,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 6,OrderNumber = "A5845DS6",OrderDate = DateTime.Now.AddDays(-2),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2520,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 7,OrderNumber = "A5845DS7",OrderDate = DateTime.Now.AddDays(-3),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 28820,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 8,OrderNumber = "A5845DS8",OrderDate = DateTime.Now.AddDays(-4),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 1220,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id = 9,OrderNumber = "A5845DS9",OrderDate = DateTime.Now.AddDays(-1),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 5820,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =10,OrderNumber = "A5845DS0",OrderDate = DateTime.Now.AddDays(-2),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 20,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =11,OrderNumber = "A5845DS1",OrderDate = DateTime.Now.AddDays(-3),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2520,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =12,OrderNumber = "A5845DS2",OrderDate = DateTime.Now.AddDays(-4),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 8520,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =13,OrderNumber = "A5845DS3",OrderDate = DateTime.Now.AddDays(-1),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2520,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =14,OrderNumber = "A5845DS4",OrderDate = DateTime.Now.AddDays(-2),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 22520,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =15,OrderNumber = "A5845DS5",OrderDate = DateTime.Now.AddDays(-3),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2820,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =16,OrderNumber = "A5845DS6",OrderDate = DateTime.Now.AddDays(-4),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 250,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =17,OrderNumber = "A5845DS7",OrderDate = DateTime.Now.AddDays(-1),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 25250,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =18,OrderNumber = "A5845DS8",OrderDate = DateTime.Now.AddDays(-2),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2250,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =19,OrderNumber = "A5845DS9",OrderDate = DateTime.Now.AddDays(-3),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2250,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
              new Order() {Id =20,OrderNumber = "A5845DS0",OrderDate = DateTime.Now.AddDays(-5),FirstName = "dasdasdas",LastName = "sdadasda",Address = "dsadasda",City = "ankara",Phone = "+9055512548",Email = "sdadas@dasdsa.com",Note = "dsadasdas",PaymentId = "1",Discount = 20,ConversationId = "5",ShippingPrice=25,TotalPrice = 2250,OrderStatus = OrderStatus.Delivery,AppUserId = 1,SellerId = 1},
            });
        }
    }

    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(new List<OrderItem>()
            {
                new OrderItem() {Id = 1,ProductPrice = 155,ProductDiscount = 2,ImageUrl = "https://www.shutterstock.com/image-photo/beautiful-water-drop-on-dandelion-260nw-789676552.jpg",Quantity = 2,OrderId = 1,ProductId = 1},
                new OrderItem() {Id = 2,ProductPrice = 85,ProductDiscount = 3,ImageUrl = "https://www.shutterstock.com/image-photo/beautiful-water-drop-on-dandelion-260nw-789676552.jpg",Quantity = 1,OrderId = 1,ProductId = 2},
                new OrderItem() {Id = 3,ProductPrice = 10,ProductDiscount = 1,ImageUrl = "https://www.shutterstock.com/image-photo/beautiful-water-drop-on-dandelion-260nw-789676552.jpg",Quantity = 3,OrderId = 1,ProductId = 3},
            });
        }
    }

    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new List<Category>()
            {
                new Category() { Id = 1, Name = "cat1", SellerId = 1 },
                new Category() { Id = 2, Name = "cat2", SellerId = 1 }
            });
        }
    }
}
