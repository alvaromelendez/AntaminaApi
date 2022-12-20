using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class CauseDetail
    {
        [JsonPropertyName("results")]
        public List<CauseResult> Results { get; set; }
    }

    public class CauseDeferred
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }

    public class CauseMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class CauseResult
    {
        [JsonPropertyName("__metadata")]
        public CauseMetadata Metadata { get; set; }

        [JsonPropertyName("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonPropertyName("MaintenanceNotificationItem")]
        public string MaintenanceNotificationItem { get; set; }

        [JsonPropertyName("MaintenanceNotificationCause")]
        public string MaintenanceNotificationCause { get; set; }

        [JsonPropertyName("MaintNotifCauseText")]
        public string MaintNotifCauseText { get; set; }

        [JsonPropertyName("MaintNotifCauseCodeGroup")]
        public string MaintNotifCauseCodeGroup { get; set; }

        [JsonPropertyName("MaintNotifCauseCodeGroupName")]
        public string MaintNotifCauseCodeGroupName { get; set; }

        [JsonPropertyName("MaintNotificationCauseCode")]
        public string MaintNotificationCauseCode { get; set; }

        [JsonPropertyName("MaintNotificationCauseCodeName")]
        public string MaintNotificationCauseCodeName { get; set; }

        [JsonPropertyName("MaintNotificationRootCause")]
        public string MaintNotificationRootCause { get; set; }

        [JsonPropertyName("MaintNotificationRootCauseText")]
        public string MaintNotificationRootCauseText { get; set; }

        [JsonPropertyName("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("to_Item")]
        public CauseToItem ToItem { get; set; }

        [JsonPropertyName("to_Notif")]
        public CauseToNotif ToNotif { get; set; }
    }

    public class ModelCause
    {
        [JsonPropertyName("d")]
        public CauseDetail D { get; set; }
    }

    public class CauseToItem
    {
        [JsonPropertyName("__deferred")]
        public CauseDeferred Deferred { get; set; }
    }

    public class CauseToNotif
    {
        [JsonPropertyName("__deferred")]
        public CauseDeferred Deferred { get; set; }
    }

    public class ModelCauseCreate
    {

    }
}
