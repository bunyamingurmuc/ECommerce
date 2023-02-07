using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Configurations.AutoIncludes
{
    public class AutoIncludes
    {
        public static void AutoInclude(ModelBuilder builder)
        {
        //    builder.Entity<AppUser>().Navigation(x => x.Reviews).AutoInclude();
        //    builder.Entity<AppUser>().Navigation(x => x.Card).AutoInclude();
        //    builder.Entity<AppUser>().Navigation(x => x.Seller).AutoInclude();
        //    builder.Entity<AppUser>().Navigation(x => x.Orders).AutoInclude();

        //    builder.Entity<Card>().Navigation(x => x.AppUser).AutoInclude();
        //    builder.Entity<Card>().Navigation(x => x.CardItems).AutoInclude();

        //    builder.Entity<CardItem>().Navigation(x => x.Product).AutoInclude();
        //    builder.Entity<CardItem>().Navigation(x => x.Card).AutoInclude();

        //    builder.Entity<Category>().Navigation(x => x.Products).AutoInclude();
        //    builder.Entity<Category>().Navigation(x => x.Seller).AutoInclude();

        //    builder.Entity<Image>().Navigation(x => x.Product).AutoInclude();

        //    builder.Entity<Order>().Navigation(x => x.OrderItems).AutoInclude();
        //    builder.Entity<Order>().Navigation(x => x.AppUser).AutoInclude();

        //    builder.Entity<OrderItem>().Navigation(x => x.Order).AutoInclude();
        //    builder.Entity<OrderItem>().Navigation(x => x.Product).AutoInclude();

        //    builder.Entity<Product>().Navigation(x => x.Category).AutoInclude();
        //    builder.Entity<Product>().Navigation(x => x.Reviews).AutoInclude();
        //    builder.Entity<Product>().Navigation(x => x.Seller).AutoInclude();
        //    builder.Entity<Product>().Navigation(x => x.OrderItems).AutoInclude();
        //    builder.Entity<Product>().Navigation(x => x.Images).AutoInclude();
        //    builder.Entity<Product>().Navigation(x => x.CardItems).AutoInclude();

        //    builder.Entity<Review>().Navigation(x => x.AppUser).AutoInclude();
        //    builder.Entity<Review>().Navigation(x => x.Product).AutoInclude();

        //    builder.Entity<Seller>().Navigation(x => x.Categories).AutoInclude();
        //    builder.Entity<Seller>().Navigation(x => x.Products).AutoInclude();
        //    builder.Entity<Seller>().Navigation(x => x.Orders).AutoInclude();
        //    builder.Entity<Seller>().Navigation(x => x.AppUsers).AutoInclude();
        }
    }
}
