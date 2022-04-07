using System.Text.Json.Serialization;

namespace PokeApiConnector.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
