using PokeApiConnector.Models;

namespace PokeApiConnector.Interfaces
{
    public interface IPokeApiService
    {
        Task<Pokemon> Get(int number);
        Task<Pokemon> Get(string name);
    }
}
