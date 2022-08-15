using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class Spot
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("image")]
        public object Image { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("spot_image_type")]
        public string SpotImageType { get; set; }

        [JsonPropertyName("thumbnails")]
        public Thumbnails Thumbnails { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("attachment_id")]
        public long? AttachmentId { get; set; }

        [JsonPropertyName("attachment_name")]
        public string AttachmentName { get; set; }

        [JsonPropertyName("attachment_image_url")]
        public Uri AttachmentImageUrl { get; set; }
    }
}
