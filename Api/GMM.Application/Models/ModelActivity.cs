using Newtonsoft.Json;

namespace GMM.Application.Models
{
    public class ActivityDetail
    {
        [JsonProperty("results")]
        public List<ActivityResult> Results { get; set; }
    }

    public class ActivityDeferred
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ActivityMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ActivityResult
    {
        [JsonProperty("__metadata")]
        public ActivityMetadata Metadata { get; set; }

        [JsonProperty("MaintNotificationActivity")]
        public string MaintNotificationActivity { get; set; }

        [JsonProperty("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonProperty("MaintenanceNotificationItem")]
        public string MaintenanceNotificationItem { get; set; }

        [JsonProperty("MaintNotifActivitySortNumber")]
        public string MaintNotifActivitySortNumber { get; set; }

        [JsonProperty("MaintNotifActyTxt")]
        public string MaintNotifActyTxt { get; set; }

        [JsonProperty("MaintNotifActivityCodeGroup")]
        public string MaintNotifActivityCodeGroup { get; set; }

        [JsonProperty("NotifActivityCodeGroupText")]
        public string NotifActivityCodeGroupText { get; set; }

        [JsonProperty("MaintNotificationActivityCode")]
        public string MaintNotificationActivityCode { get; set; }

        [JsonProperty("NotifActivityCodeText")]
        public string NotifActivityCodeText { get; set; }

        [JsonProperty("PlannedStartDate")]
        public DateTime PlannedStartDate { get; set; }

        [JsonProperty("PlannedStartTime")]
        public string PlannedStartTime { get; set; }

        [JsonProperty("PlannedEndDate")]
        public object PlannedEndDate { get; set; }

        [JsonProperty("PlannedEndTime")]
        public string PlannedEndTime { get; set; }

        [JsonProperty("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("to_Item")]
        public ActivityToItem ToItem { get; set; }

        [JsonProperty("to_Notif")]
        public ActivityToNotif ToNotif { get; set; }
    }

    public class ModelActivity
    {
        [JsonProperty("d")]
        public ActivityDetail D { get; set; }
    }

    public class ActivityToItem
    {
        [JsonProperty("__deferred")]
        public ActivityDeferred Deferred { get; set; }
    }

    public class ActivityToNotif
    {
        [JsonProperty("__deferred")]
        public ActivityDeferred Deferred { get; set; }
    }

    public class ModelActivityCreate
    {
        [JsonProperty("d")]
        public ActivityResult D { get; set; }
    }
}
