using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class SpotWaitingOption
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("spot_id")]
        public long SpotId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("default_value")]
        public object DefaultValue { get; set; }

        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        [JsonPropertyName("option_type")]
        public string OptionType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("options")]
        public string Options { get; set; }

        [JsonPropertyName("ordinal")]
        public long Ordinal { get; set; }

        [JsonPropertyName("online_required_option_type")]
        public object OnlineRequiredOptionType { get; set; }
    }
}
