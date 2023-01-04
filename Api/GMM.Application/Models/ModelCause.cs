using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class CauseDetail
    {
        [JsonProperty("results")]
        public List<CauseResult> Results { get; set; }
    }

    public class CauseDeferred
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CauseMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CauseResult
    {
        [JsonProperty("__metadata")]
        public CauseMetadata Metadata { get; set; }

        [JsonProperty("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonProperty("MaintenanceNotificationItem")]
        public string MaintenanceNotificationItem { get; set; }

        [JsonProperty("MaintenanceNotificationCause")]
        public string MaintenanceNotificationCause { get; set; }

        [JsonProperty("MaintNotifCauseText")]
        public string MaintNotifCauseText { get; set; }

        [JsonProperty("MaintNotifCauseCodeGroup")]
        public string MaintNotifCauseCodeGroup { get; set; }

        [JsonProperty("MaintNotifCauseCodeGroupName")]
        public string MaintNotifCauseCodeGroupName { get; set; }

        [JsonProperty("MaintNotificationCauseCode")]
        public string MaintNotificationCauseCode { get; set; }

        [JsonProperty("MaintNotificationCauseCodeName")]
        public string MaintNotificationCauseCodeName { get; set; }

        [JsonProperty("MaintNotificationRootCause")]
        public string MaintNotificationRootCause { get; set; }

        [JsonProperty("MaintNotificationRootCauseText")]
        public string MaintNotificationRootCauseText { get; set; }

        [JsonProperty("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("to_Item")]
        public CauseToItem ToItem { get; set; }

        [JsonProperty("to_Notif")]
        public CauseToNotif ToNotif { get; set; }
    }

    public class ModelCause
    {
        [JsonProperty("d")]
        public CauseDetail D { get; set; }
    }

    public class CauseToItem
    {
        [JsonProperty("__deferred")]
        public CauseDeferred Deferred { get; set; }
    }

    public class CauseToNotif
    {
        [JsonProperty("__deferred")]
        public CauseDeferred Deferred { get; set; }
    }

    public class ModelCauseCreate
    {

    }
}
