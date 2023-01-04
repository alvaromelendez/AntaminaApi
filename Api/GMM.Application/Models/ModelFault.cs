using GMM.Domain.Entities;
using Newtonsoft.Json;

namespace GMM.Application.Models
{
    public class FaultResult
    {
        [JsonProperty("__metadata")]
        public FaultMetadata Metadata { get; set; }

        [JsonProperty("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonProperty("MaintenanceNotificationItem")]
        public string MaintenanceNotificationItem { get; set; }

        [JsonProperty("MaintNotifItemText")]
        public string MaintNotifItemText { get; set; }

        [JsonProperty("MaintNotifDamageCodeGroup")]
        public string MaintNotifDamageCodeGroup { get; set; }

        [JsonProperty("MaintNotifDamageCodeGroupName")]
        public string MaintNotifDamageCodeGroupName { get; set; }

        [JsonProperty("MaintNotificationDamageCode")]
        public string MaintNotificationDamageCode { get; set; }

        [JsonProperty("MaintNotifDamageCodeName")]
        public string MaintNotifDamageCodeName { get; set; }

        [JsonProperty("MaintNotifObjPrtCodeGroup")]
        public string MaintNotifObjPrtCodeGroup { get; set; }

        [JsonProperty("MaintNotifObjPrtCodeGroupName")]
        public string MaintNotifObjPrtCodeGroupName { get; set; }

        [JsonProperty("MaintNotifObjPrtCode")]
        public string MaintNotifObjPrtCode { get; set; }

        [JsonProperty("MaintNotifObjPrtCodeName")]
        public string MaintNotifObjPrtCodeName { get; set; }

        [JsonProperty("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("to_ItemActivity")]
        public FaultToItemActivity ToItemActivity { get; set; }

        [JsonProperty("to_ItemCause")]
        public FaultToItemCause ToItemCause { get; set; }

        [JsonProperty("to_Notif")]
        public FaultToNotif ToNotif { get; set; }
    }

    public class FaultDeferred
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class FaultMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ModelFault
    {
        [JsonProperty("d")]
        public FaultResult D { get; set; }
    }

    public class FaultToItemActivity
    {
        [JsonProperty("__deferred")]
        public FaultDeferred Deferred { get; set; }
    }

    public class FaultToItemCause
    {
        [JsonProperty("__deferred")]
        public FaultDeferred Deferred { get; set; }
    }

    public class FaultToNotif
    {
        [JsonProperty("__deferred")]
        public FaultDeferred Deferred { get; set; }
    }

    public class ModelFaultResult
    {
        [JsonProperty("results")]
        public List<FaultResult> Results { get; set; }
    }

    public class ModelFaultDetail
    {
        [JsonProperty("d")]
        public ModelFaultResult D { get; set; }
    }










    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    //public class D
    //{
    //    [JsonProperty("__metadata")]
    //    public Metadata Metadata { get; set; }

    //    [JsonProperty("MaintenanceNotification")]
    //    public string MaintenanceNotification { get; set; }

    //    [JsonProperty("MaintenanceNotificationItem")]
    //    public string MaintenanceNotificationItem { get; set; }

    //    [JsonProperty("MaintNotifItemText")]
    //    public string MaintNotifItemText { get; set; }

    //    [JsonProperty("MaintNotifDamageCodeGroup")]
    //    public string MaintNotifDamageCodeGroup { get; set; }

    //    [JsonProperty("MaintNotifDamageCodeGroupName")]
    //    public string MaintNotifDamageCodeGroupName { get; set; }

    //    [JsonProperty("MaintNotificationDamageCode")]
    //    public string MaintNotificationDamageCode { get; set; }

    //    [JsonProperty("MaintNotifDamageCodeName")]
    //    public string MaintNotifDamageCodeName { get; set; }

    //    [JsonProperty("MaintNotifObjPrtCodeGroup")]
    //    public string MaintNotifObjPrtCodeGroup { get; set; }

    //    [JsonProperty("MaintNotifObjPrtCodeGroupName")]
    //    public string MaintNotifObjPrtCodeGroupName { get; set; }

    //    [JsonProperty("MaintNotifObjPrtCode")]
    //    public string MaintNotifObjPrtCode { get; set; }

    //    [JsonProperty("MaintNotifObjPrtCodeName")]
    //    public string MaintNotifObjPrtCodeName { get; set; }

    //    [JsonProperty("IsDeleted")]
    //    public bool IsDeleted { get; set; }

    //    [JsonProperty("to_ItemActivity")]
    //    public ToItemActivity ToItemActivity { get; set; }

    //    [JsonProperty("to_ItemCause")]
    //    public ToItemCause ToItemCause { get; set; }

    //    [JsonProperty("to_Notif")]
    //    public ToNotif ToNotif { get; set; }
    //}

    //public class Deferred
    //{
    //    [JsonProperty("uri")]
    //    public string Uri { get; set; }
    //}

    //public class Metadata
    //{
    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("uri")]
    //    public string Uri { get; set; }

    //    [JsonProperty("type")]
    //    public string Type { get; set; }
    //}

    public class FaultResultCreate
    {
        [JsonProperty("d")]
        public FaultResult D { get; set; }
    }

    //public class ToItemActivity
    //{
    //    [JsonProperty("__deferred")]
    //    public Deferred Deferred { get; set; }
    //}

    //public class ToItemCause
    //{
    //    [JsonProperty("__deferred")]
    //    public Deferred Deferred { get; set; }
    //}

    //public class ToNotif
    //{
    //    [JsonProperty("__deferred")]
    //    public Deferred Deferred { get; set; }
    //}


}
