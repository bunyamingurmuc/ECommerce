using ECommerce.DAL.Configurations;
using ECommerce.DAL.Configurations.AutoIncludes;
using ECommerce.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using ECommerce.DAL.Configurations.Relations;

namespace ECommerce.DAL.Context
{
    public class ECommerceContext : DbContext
    {

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }
        public DbSet<AppUser>? AppUsers { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Seller>? Sellers { get; set; }
        public DbSet<Card>? Cards { get; set; }
        public DbSet<CardItem>? CardItems { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<Image>? Images { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new ReviewConfig());
            builder.ApplyConfiguration(new SellerConfig());
            builder.ApplyConfiguration(new CardConfig());
            builder.ApplyConfiguration(new CardItemConfig());
            builder.ApplyConfiguration(new OrderConfig());

            //AutoIncludes.AutoInclude(builder);
            ApplyRelations.ApplyRelation(builder);
            base.OnModelCreating(builder);
            
        }
    }
}


