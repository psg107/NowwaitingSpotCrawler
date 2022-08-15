using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class UserCouponsData
    {
        [JsonPropertyName("sent_coupon_count")]
        public long SentCouponCount { get; set; }

        [JsonPropertyName("used_coupon_count")]
        public long UsedCouponCount { get; set; }
    }
}
