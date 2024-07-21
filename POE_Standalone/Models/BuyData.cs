using System.Text.Json.Serialization;

namespace POE.Models
{
    public class BuyData
    {
        [JsonPropertyName("npc")]
        public string? Npc { get; set; }

        [JsonPropertyName("act")]
        public int Act { get; set; }

        [JsonPropertyName("town")]
        public string? Town { get; set; }

        [JsonPropertyName("available_to")]
        public List<string>? AvailableTo { get; set; }

        [JsonPropertyName("quest_name")]
        public string? QuestName { get; set; }
    }
}
