using Microsoft.Extensions.DependencyInjection;
using PokeApiConnector.Api;
using PokeApiConnector.Interfaces;
using PokeApiConnector.Services;
using Refit;

namespace PokeApiConnector
{
    public static class ModuleDependency
    {
        public static void AddPokeApiModule(this IServiceCollection services)
        {
            services.AddSingleton(RestService.For<IPokeApi>("https://pokeapi.co/api/v2"));
            services.AddScoped<IPokeApiService, PokeApiService>();
        }
    }
}