using ECommerce.DAL.Configurations;
using ECommerce.Entity;
using Microsoft.EntityFrameworkCore;

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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfigurations());
            builder.Entity<AppUser>().Navigation(x => x.Reviews).AutoInclude();
            builder.Entity<Product>().Navigation(x => x.Category).AutoInclude();
            builder.Entity<Product>().Navigation(x => x.Reviews).AutoInclude();
            builder.Entity<Product>().Navigation(x => x.Seller).AutoInclude();
            builder.Entity<Category>().Navigation(x => x.Products).AutoInclude();
            builder.Entity<Category>().Navigation(x => x.Seller).AutoInclude();
            builder.Entity<Review>().Navigation(x => x.AppUser).AutoInclude();
            builder.Entity<Review>().Navigation(x => x.Product).AutoInclude();
            builder.Entity<Seller>().Navigation(x => x.Categories).AutoInclude();
            builder.Entity<Seller>().Navigation(x => x.Products).AutoInclude();
            builder.Entity<Card>()
                .HasOne(i => i.AppUser)
                .WithOne(i => i.Card)
                .HasForeignKey<AppUser>(x => x.CardId);
            base.OnModelCreating(builder);
        }
    }
}


