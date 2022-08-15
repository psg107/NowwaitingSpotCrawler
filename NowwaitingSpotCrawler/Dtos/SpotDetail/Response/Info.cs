using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class Info
    {
        [JsonPropertyName("queued_waitings_count")]
        public long QueuedWaitingsCount { get; set; }

        [JsonPropertyName("remaining_minutes_text")]
        public string RemainingMinutesText { get; set; }

        [JsonPropertyName("remaining_minutes")]
        public long RemainingMinutes { get; set; }
    }
}
