using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class Image
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonPropertyName("image_type")]
        public string ImageType { get; set; }

        [JsonPropertyName("thumbnails")]
        public Thumbnail Thumbnails { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
    }
}
