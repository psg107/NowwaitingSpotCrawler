using System.Text.Json.Serialization;

namespace NowwaitingSpotCrawler.Dtos.SpotDetail.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class SpotDetailResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("spot_type")]
        public string SpotType { get; set; }

        [JsonPropertyName("pg_type")]
        public string PgType { get; set; }

        [JsonPropertyName("display_type")]
        public string DisplayType { get; set; }

        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        [JsonPropertyName("user_code")]
        public string UserCode { get; set; }

        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }

        [JsonPropertyName("waiting_info")]
        public Info WaitingInfo { get; set; }

        [JsonPropertyName("is_open")]
        public bool IsOpen { get; set; }

        [JsonPropertyName("using_now_waiting")]
        public bool UsingNowWaiting { get; set; }

        [JsonPropertyName("spot_waiting_options")]
        public SpotWaitingOption[] SpotWaitingOptions { get; set; }

        [JsonPropertyName("point_type")]
        public string PointType { get; set; }

        [JsonPropertyName("minimum_point_usage")]
        public long MinimumPointUsage { get; set; }

        [JsonPropertyName("using_expected_waiting_time")]
        public bool UsingExpectedWaitingTime { get; set; }

        [JsonPropertyName("spot_images")]
        public Spot[] SpotImages { get; set; }

        [JsonPropertyName("how_to_use_point")]
        public string[] HowToUsePoint { get; set; }

        [JsonPropertyName("how_to_use_coupon")]
        public string[] HowToUseCoupon { get; set; }

        [JsonPropertyName("spot_covers")]
        public Spot[] SpotCovers { get; set; }

        [JsonPropertyName("mall_group_id")]
        public object MallGroupId { get; set; }

        [JsonPropertyName("max_party_size")]
        public long MaxPartySize { get; set; }

        [JsonPropertyName("waiting_type")]
        public string WaitingType { get; set; }

        [JsonPropertyName("spot_party_options")]
        public SpotPartyOption[] SpotPartyOptions { get; set; }

        [JsonPropertyName("using_party_size")]
        public bool UsingPartySize { get; set; }

        [JsonPropertyName("using_point_tab")]
        public bool UsingPointTab { get; set; }

        [JsonPropertyName("using_coupon_tab")]
        public bool UsingCouponTab { get; set; }

        [JsonPropertyName("using_order_service")]
        public bool UsingOrderService { get; set; }

        [JsonPropertyName("current_business_hours")]
        public CurrentBusinessHours CurrentBusinessHours { get; set; }

        [JsonPropertyName("pre_order_info")]
        public Info PreOrderInfo { get; set; }

        [JsonPropertyName("max_stamps_count")]
        public long? MaxStampsCount { get; set; }

        [JsonPropertyName("waiting_modify")]
        public bool WaitingModify { get; set; }

        [JsonPropertyName("service_color")]
        public string ServiceColor { get; set; }

        [JsonPropertyName("floor")]
        public long Floor { get; set; }

        [JsonPropertyName("seating_capacity")]
        public long SeatingCapacity { get; set; }

        [JsonPropertyName("user_coupons_data")]
        public UserCouponsData UserCouponsData { get; set; }

        [JsonPropertyName("message_type")]
        public string MessageType { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("personnel_type")]
        public string PersonnelType { get; set; }

        [JsonPropertyName("sign_description")]
        public object SignDescription { get; set; }

        [JsonPropertyName("staff_user_ids")]
        public long[] StaffUserIds { get; set; }

        [JsonPropertyName("manager_user_ids")]
        public long[] ManagerUserIds { get; set; }

        [JsonPropertyName("alert_manual_saving_point")]
        public bool AlertManualSavingPoint { get; set; }

        [JsonPropertyName("is_delivery")]
        public bool IsDelivery { get; set; }

        [JsonPropertyName("delivery_hours")]
        public object[] DeliveryHours { get; set; }

        [JsonPropertyName("delivery_fees")]
        public object[] DeliveryFees { get; set; }

        [JsonPropertyName("channel_public_id")]
        public object ChannelPublicId { get; set; }

        [JsonPropertyName("active_order_channels")]
        public string[] ActiveOrderChannels { get; set; }

        [JsonPropertyName("mobile_store_version")]
        public string MobileStoreVersion { get; set; }

        [JsonPropertyName("using_delivery_in_mobile_store")]
        public bool UsingDeliveryInMobileStore { get; set; }

        [JsonPropertyName("using_pickup_in_mobile_store")]
        public bool UsingPickupInMobileStore { get; set; }

        [JsonPropertyName("last_business_date")]
        public DateTimeOffset LastBusinessDate { get; set; }

        [JsonPropertyName("checkin_exists")]
        public bool CheckinExists { get; set; }

        [JsonPropertyName("using_checkin")]
        public bool UsingCheckin { get; set; }

        [JsonPropertyName("using_samsung_kiosk")]
        public bool UsingSamsungKiosk { get; set; }

        [JsonPropertyName("restaurant_type")]
        public object RestaurantType { get; set; }

        [JsonPropertyName("last_address")]
        public LastAddress LastAddress { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("pin_number")]
        public string PinNumber { get; set; }

        [JsonPropertyName("inspection_status")]
        public string InspectionStatus { get; set; }

        [JsonPropertyName("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonPropertyName("attachment_name")]
        public object AttachmentName { get; set; }

        [JsonPropertyName("attachment_image_url")]
        public object AttachmentImageUrl { get; set; }
    }
}
