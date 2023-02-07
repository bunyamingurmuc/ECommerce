using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Configurations.Relations
{
    public class ApplyRelations
    {
        public static void ApplyRelation(ModelBuilder builder)
        {
            builder.Entity<Product>().HasMany(i => i.OrderItems).WithOne(i => i.Product).HasForeignKey(i => i.ProductId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Product>().HasMany(i => i.Reviews).WithOne(i => i.Product).HasForeignKey(i => i.ProductId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Product>().HasMany(i => i.CardItems).WithOne(i => i.Product).HasForeignKey(i => i.ProductId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Product>().HasMany(i => i.Images).WithOne(i => i.Product).HasForeignKey(i => i.ProductId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Product>().HasOne(i => i.Seller).WithMany(i => i.Products).HasForeignKey(i => i.SellerId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<AppUser>().HasMany(i => i.Reviews).WithOne(i => i.AppUser).HasForeignKey(i => i.AppUserId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<AppUser>().HasMany(i => i.Orders).WithOne(i => i.AppUser).HasForeignKey(i => i.AppUserId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
          
            builder.Entity<Category>().HasMany(i => i.Products).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Order>().HasMany(i => i.OrderItems).WithOne(i => i.Order).HasForeignKey(i => i.OrderId).IsRequired(false).OnDelete(DeleteBehavior.Cascade);
          
            builder.Entity<Seller>().HasMany(i => i.Categories).WithOne(i => i.Seller).HasForeignKey(i => i.SellerId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Seller>().HasMany(i => i.Products).WithOne(i => i.Seller).HasForeignKey(i => i.SellerId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Seller>().HasMany(i => i.Orders).WithOne(i => i.Seller).HasForeignKey(i => i.SellerId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Seller>().HasMany(i => i.AppUsers).WithOne(i => i.Seller).HasForeignKey(i => i.SellerId).IsRequired(false).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Card>().HasMany(x => x.CardItems).WithOne(x => x.Card).OnDelete(DeleteBehavior.Cascade);
         
            builder.Entity<Card>()
                .HasOne(i => i.AppUser)
                .WithOne(i => i.Card)
                .HasForeignKey<AppUser>(x => x.CardId);

            builder.Entity<Product>()
                .HasOne(i => i.Seller)
                .WithMany(i => i.Products)
                .HasForeignKey(i => i.SellerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Product>()
                .HasOne(i => i.Category)
                .WithMany(i => i.Products)
                .HasForeignKey(i => i.CategoryId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Category>()
                .HasOne(i => i.Image)
                .WithOne(i => i.Category)
                .HasForeignKey<Image>(i => i.CategoryId)
                .IsRequired(false);

            builder.Entity<Image>()
                .HasOne(i => i.Category)
                .WithOne(i => i.Image)
                .HasForeignKey<Category>(i => i.ImageId)
                .IsRequired(false);
        }
    }
}
