using System.Text.Json.Serialization;

namespace POE.Models
{
    public class GemData
    {
        [JsonPropertyName("reward")]
        public Reward? Reward { get; set; }

        [JsonPropertyName("required_lvl")]
        public int RequiredLvl { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("isReward")]
        public bool IsReward { get; set; }

        [JsonPropertyName("isSupport")]
        public bool IsSupport { get; set; }

        [JsonPropertyName("buy")]
        public List<BuyData>? Buy { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("isVaal")]
        public bool IsVaal { get; set; }

        [JsonPropertyName("gemTags")]
        public List<string>? GemTags { get; set; }

        [JsonPropertyName("iconPath")]
        public string? IconPath { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    }
}
