using FBS.Domain.Interfaces;
using FBS.Domain.Interfaces.Services;
using FBS.InfraStructure.Repositories;
using FBS.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FBS.InfraStructure.Extensions
{
    public static class RepositoryExtensionDI
    {
        public static IServiceCollection RepositoryExtension(this IServiceCollection services)
        {
            services.AddTransient<IPurchaseItemRepository, PurchaseItemRepository>();
            services.AddTransient<IPurchaseItemService, PurchaseItemService>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryService, CategoryService>();

            return services;
        }
    }
}
