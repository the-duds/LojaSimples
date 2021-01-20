using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection;

namespace LojaSimples.Infra.IoC
{
    public static class DependencyResolver
    {
        public static void AddSettingsConfig(this IServiceCollection services, IConfiguration Configuration)
        {
            //services.AddSingleton<IMongoDbSettings>(serviceProvider => serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

        }

        public static void AddInterfacesAplicacao(this IServiceCollection services)
        {
            RegisterRepositories(services);
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
            
        }

        public static IEnumerable<Assembly> GetCurrentAssemblies()
        {
            return new Assembly[]
            {
                Assembly.Load("LojaSimples"),
                Assembly.Load("LojaSimples.Application"),
                Assembly.Load("LojaSimples.Domain"),
                Assembly.Load("LojaSimples.Infra.Data")
            };
        }
    }
}
