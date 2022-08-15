using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    public class LastAddress
    {
        [JsonPropertyName("full_address")]
        public string FullAddress { get; set; }

        [JsonPropertyName("address_detail")]
        public string AddressDetail { get; set; }
    }
}
