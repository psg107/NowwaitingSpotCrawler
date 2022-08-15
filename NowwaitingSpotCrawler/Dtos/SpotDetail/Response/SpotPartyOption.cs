using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class SpotPartyOption
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("spot_id")]
        public long SpotId { get; set; }

        [JsonPropertyName("menu_id")]
        public object MenuId { get; set; }

        [JsonPropertyName("ordinal")]
        public long Ordinal { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("party_option_type")]
        public string PartyOptionType { get; set; }

        [JsonPropertyName("condition_type")]
        public string ConditionType { get; set; }

        [JsonPropertyName("condition_value")]
        public long? ConditionValue { get; set; }
    }
}
