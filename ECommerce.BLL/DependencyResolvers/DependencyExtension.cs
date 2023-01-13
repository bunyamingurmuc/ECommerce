using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.BLL.Services;
using ECommerce.BLL.ValidationRules;
using ECommerce.DAL.Context;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wkhtmltopdf.NetCore;

namespace ECommerce.BLL.DependencyResolvers
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ECommerceContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });
            services.AddWkhtmltopdf("wkhtmltopdf");

            services.AddScoped<IUOW, UOW>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<ISellerService, SellerService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ICardItemService, CardItemService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderItemService, OrderItemService>();

            services.AddSingleton<IValidator<AppUser>, AppUserValidator>();
            services.AddSingleton<IValidator<Category>, CategoryValidator>();
            services.AddSingleton<IValidator<Product>, ProductValidator>();
            services.AddSingleton<IValidator<Review>, ReviewValidator>();
            services.AddSingleton<IValidator<Seller>, SellerValidator>();
            services.AddSingleton<IValidator<Card>, CardValidator>();
            services.AddSingleton<IValidator<CardItem>, CardItemValidator>();
            services.AddSingleton<IValidator<Order>, OrderValidator>();
            services.AddSingleton<IValidator<OrderItem>, OrderItemValidator>();
        }
    }
}
