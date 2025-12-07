using Library.Application.ManagerInterfaces;
using Library.InnerInfrastructure.ManagerConcretes;
using Microsoft.Extensions.DependencyInjection;

namespace Library.InnerInfrastructure.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static IServiceCollection AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<IBookManager, BookManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ITagManager, TagManager>();
            services.AddScoped<IBookTagManager, BookTagManager>();
            
            return services;
        }
    }
}

