using PokeApiConnector.Models;
using Refit;

namespace PokeApiConnector.Api
{
    internal interface IPokeApi
    {
        [Get("/pokemon/{number}")]
        Task<Pokemon> Get([AliasAs("number")]int number);
    }
}
