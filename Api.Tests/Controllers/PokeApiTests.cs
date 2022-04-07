using NUnit.Framework;
using PokeApiConnector.Models;
using System.Threading.Tasks;

namespace Api.Tests.Controllers
{
    internal class PokeApiTests
    {
        private const string BASE_PATH = "/api/Pokemons";

        [Test]
        [TestCase("pikachu", 25)]
        [TestCase("mewtwo", 150)]
        public async Task Deve_Buscar_Por_Numero(string expected, int number)
        {
            // Arrange
            await using var application = new WebAppFactory();
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync(BASE_PATH + "?number= " + number);
            var actual = await response.DeserializeContentAsync<Pokemon>();

            // Assert
            Assert.AreEqual(expected, actual.Name);
            Assert.AreEqual(number, actual.Id);

        }
    }
}