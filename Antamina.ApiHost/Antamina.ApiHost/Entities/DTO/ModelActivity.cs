using System.Text.Json.Serialization;

namespace Antamina.ApiHost.Entities.DTO
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class D
    {
        [JsonPropertyName("results")]
        public List<Result2> results { get; set; }
    }

    public class Deferred2
    {
        [JsonPropertyName("uri")]
        public string uri { get; set; }
    }

    public class Metadata2
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("uri")]
        public string uri { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }
    }

    public class Result2
    {
        [JsonPropertyName("__metadata")]
        public Metadata2 __metadata { get; set; }

        [JsonPropertyName("MaintNotificationActivity")]
        public string MaintNotificationActivity { get; set; }

        [JsonPropertyName("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonPropertyName("MaintenanceNotificationItem")]
        public string MaintenanceNotificationItem { get; set; }

        [JsonPropertyName("MaintNotifActivitySortNumber")]
        public string MaintNotifActivitySortNumber { get; set; }

        [JsonPropertyName("MaintNotifActyTxt")]
        public string MaintNotifActyTxt { get; set; }

        [JsonPropertyName("MaintNotifActivityCodeGroup")]
        public string MaintNotifActivityCodeGroup { get; set; }

        [JsonPropertyName("NotifActivityCodeGroupText")]
        public string NotifActivityCodeGroupText { get; set; }

        [JsonPropertyName("MaintNotificationActivityCode")]
        public string MaintNotificationActivityCode { get; set; }

        [JsonPropertyName("NotifActivityCodeText")]
        public string NotifActivityCodeText { get; set; }

        [JsonPropertyName("PlannedStartDate")]
        public DateTime PlannedStartDate { get; set; }

        [JsonPropertyName("PlannedStartTime")]
        public string PlannedStartTime { get; set; }

        [JsonPropertyName("PlannedEndDate")]
        public object PlannedEndDate { get; set; }

        [JsonPropertyName("PlannedEndTime")]
        public string PlannedEndTime { get; set; }

        [JsonPropertyName("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("to_Item")]
        public ToItem2 to_Item { get; set; }

        [JsonPropertyName("to_Notif")]
        public ToNotif to_Notif { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("d")]
        public D d { get; set; }
    }

    public class ToItem2
    {
        [JsonPropertyName("__deferred")]
        public Deferred2 __deferred { get; set; }
    }

    public class ToNotif
    {
        [JsonPropertyName("__deferred")]
        public Deferred2 __deferred { get; set; }
    }


}
