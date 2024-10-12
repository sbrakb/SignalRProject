using Microsoft.Extensions.DependencyInjection;
using SignalRWebUI.DataAccessLayer.Abstracts;
using SignalRWebUI.DataAccessLayer.Concretes.EntityFramework;

namespace SignalRWebUI.DataAccessLayer;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddScoped<IAboutDal, EfAboutDal>();
        services.AddScoped<IBookingDal, EfBookingDal>();
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<IContactDal, EfContactDal>();
        services.AddScoped<IDiscountDal, EfDiscountDal>();
        services.AddScoped<IFeatureDal, EfFeatureDal>();
        services.AddScoped<IProductDal, EfProductDal>();
        services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
        services.AddScoped<ITestimoinalDal, EfTestimoinalDal>();

        return services;
    }
}
