using PokeApiConnector.Api;
using PokeApiConnector.Interfaces;
using PokeApiConnector.Models;

namespace PokeApiConnector.Services
{
    internal class PokeApiService : IPokeApiService
    {
        private readonly IPokeApi _api;
        public PokeApiService(IPokeApi api)
        {
            _api = api;
        }
        public Task<Pokemon> Get(int number)
        {
            return _api.Get(number);
        }

        public Task<Pokemon> Get(string name)
        {
            throw new NotImplementedException();
        }
    }
}
