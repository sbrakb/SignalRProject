using Microsoft.Extensions.DependencyInjection;
using SignalR.BusinessLayer.Abstracts;
using SignalR.BusinessLayer.Concretes;
using System.Reflection;

namespace SignalR.BusinessLayer;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(assembly);

        services.AddScoped<IAboutService, AboutManager>();
        services.AddScoped<IBookingService, BookingManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IDiscountService, DiscountManager>();
        services.AddScoped<IFeatureService, FeatureManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<ISocialMediaService, SocialMediaManager>();
        services.AddScoped<ITestimoinalService, TestimoinalManager>();

        return services;
    }
}
