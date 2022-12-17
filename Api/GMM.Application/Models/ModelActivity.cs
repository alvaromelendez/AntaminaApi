﻿using System.Text.Json.Serialization;

namespace GMM.Application.Models
{
    public class ActivityDetail
    {
        [JsonPropertyName("results")]
        public List<ActivityResult> Results { get; set; }
    }

    public class ActivityDeferred
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }

    public class ActivityMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class ActivityResult
    {
        [JsonPropertyName("__metadata")]
        public ActivityMetadata Metadata { get; set; }

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
        public ActivityToItem ToItem { get; set; }

        [JsonPropertyName("to_Notif")]
        public ActivityToNotif ToNotif { get; set; }
    }

    public class ModelActivity
    {
        [JsonPropertyName("d")]
        public ActivityDetail D { get; set; }
    }

    public class ActivityToItem
    {
        [JsonPropertyName("__deferred")]
        public ActivityDeferred Deferred { get; set; }
    }

    public class ActivityToNotif
    {
        [JsonPropertyName("__deferred")]
        public ActivityDeferred Deferred { get; set; }
    }

    public class ModelActivityCreate
    {
        [JsonPropertyName("d")]
        public ActivityResult D { get; set; }
    }
}
