using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class Thumbnail
    {
        [JsonPropertyName("large")]
        public Uri Large { get; set; }

        [JsonPropertyName("low")]
        public Uri Low { get; set; }

        [JsonPropertyName("square")]
        public Uri Square { get; set; }
    }
}
