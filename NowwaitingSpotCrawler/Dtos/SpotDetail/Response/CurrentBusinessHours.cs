using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class CurrentBusinessHours
    {
        [JsonPropertyName("started_at")]
        public string StartedAt { get; set; }

        [JsonPropertyName("finished_at")]
        public string FinishedAt { get; set; }

        [JsonPropertyName("last_order_at")]
        public object LastOrderAt { get; set; }

        [JsonPropertyName("breaktime_start_at")]
        public object BreaktimeStartAt { get; set; }

        [JsonPropertyName("breaktime_end_at")]
        public object BreaktimeEndAt { get; set; }
    }
}
