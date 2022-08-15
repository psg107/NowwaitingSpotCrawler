using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class Thumbnails
    {
        [JsonPropertyName("large")]
        public Uri Large { get; set; }

        [JsonPropertyName("middle")]
        public Uri Middle { get; set; }

        [JsonPropertyName("square")]
        public Uri Square { get; set; }

        [JsonPropertyName("small")]
        public Uri Small { get; set; }

        [JsonPropertyName("img420x420")]
        public Uri Img420X420 { get; set; }

        [JsonPropertyName("img1125xfluid")]
        public Uri Img1125Xfluid { get; set; }
    }
}
