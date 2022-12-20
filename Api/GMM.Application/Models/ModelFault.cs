using GMM.Domain.Entities;
using System.Text.Json.Serialization;

namespace GMM.Application.Models
{
    public class FaultResult
    {
        [JsonPropertyName("__metadata")]
        public FaultMetadata Metadata { get; set; }

        [JsonPropertyName("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonPropertyName("MaintenanceNotificationItem")]
        public string MaintenanceNotificationItem { get; set; }

        [JsonPropertyName("MaintNotifItemText")]
        public string MaintNotifItemText { get; set; }

        [JsonPropertyName("MaintNotifDamageCodeGroup")]
        public string MaintNotifDamageCodeGroup { get; set; }

        [JsonPropertyName("MaintNotifDamageCodeGroupName")]
        public string MaintNotifDamageCodeGroupName { get; set; }

        [JsonPropertyName("MaintNotificationDamageCode")]
        public string MaintNotificationDamageCode { get; set; }

        [JsonPropertyName("MaintNotifDamageCodeName")]
        public string MaintNotifDamageCodeName { get; set; }

        [JsonPropertyName("MaintNotifObjPrtCodeGroup")]
        public string MaintNotifObjPrtCodeGroup { get; set; }

        [JsonPropertyName("MaintNotifObjPrtCodeGroupName")]
        public string MaintNotifObjPrtCodeGroupName { get; set; }

        [JsonPropertyName("MaintNotifObjPrtCode")]
        public string MaintNotifObjPrtCode { get; set; }

        [JsonPropertyName("MaintNotifObjPrtCodeName")]
        public string MaintNotifObjPrtCodeName { get; set; }

        [JsonPropertyName("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("to_ItemActivity")]
        public FaultToItemActivity ToItemActivity { get; set; }

        [JsonPropertyName("to_ItemCause")]
        public FaultToItemCause ToItemCause { get; set; }

        [JsonPropertyName("to_Notif")]
        public FaultToNotif ToNotif { get; set; }
    }

    public class FaultDeferred
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }

    public class FaultMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class ModelFault
    {
        [JsonPropertyName("d")]
        public FaultResult D { get; set; }
    }

    public class FaultToItemActivity
    {
        [JsonPropertyName("__deferred")]
        public FaultDeferred Deferred { get; set; }
    }

    public class FaultToItemCause
    {
        [JsonPropertyName("__deferred")]
        public FaultDeferred Deferred { get; set; }
    }

    public class FaultToNotif
    {
        [JsonPropertyName("__deferred")]
        public FaultDeferred Deferred { get; set; }
    }

    public class ModelFaultResult
    {
        [JsonPropertyName("results")]
        public List<FaultResult> Results { get; set; }
    }

    public class ModelFaultDetail
    {
        [JsonPropertyName("d")]
        public ModelFaultResult D { get; set; }
    }










    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    //public class D
    //{
    //    [JsonPropertyName("__metadata")]
    //    public Metadata Metadata { get; set; }

    //    [JsonPropertyName("MaintenanceNotification")]
    //    public string MaintenanceNotification { get; set; }

    //    [JsonPropertyName("MaintenanceNotificationItem")]
    //    public string MaintenanceNotificationItem { get; set; }

    //    [JsonPropertyName("MaintNotifItemText")]
    //    public string MaintNotifItemText { get; set; }

    //    [JsonPropertyName("MaintNotifDamageCodeGroup")]
    //    public string MaintNotifDamageCodeGroup { get; set; }

    //    [JsonPropertyName("MaintNotifDamageCodeGroupName")]
    //    public string MaintNotifDamageCodeGroupName { get; set; }

    //    [JsonPropertyName("MaintNotificationDamageCode")]
    //    public string MaintNotificationDamageCode { get; set; }

    //    [JsonPropertyName("MaintNotifDamageCodeName")]
    //    public string MaintNotifDamageCodeName { get; set; }

    //    [JsonPropertyName("MaintNotifObjPrtCodeGroup")]
    //    public string MaintNotifObjPrtCodeGroup { get; set; }

    //    [JsonPropertyName("MaintNotifObjPrtCodeGroupName")]
    //    public string MaintNotifObjPrtCodeGroupName { get; set; }

    //    [JsonPropertyName("MaintNotifObjPrtCode")]
    //    public string MaintNotifObjPrtCode { get; set; }

    //    [JsonPropertyName("MaintNotifObjPrtCodeName")]
    //    public string MaintNotifObjPrtCodeName { get; set; }

    //    [JsonPropertyName("IsDeleted")]
    //    public bool IsDeleted { get; set; }

    //    [JsonPropertyName("to_ItemActivity")]
    //    public ToItemActivity ToItemActivity { get; set; }

    //    [JsonPropertyName("to_ItemCause")]
    //    public ToItemCause ToItemCause { get; set; }

    //    [JsonPropertyName("to_Notif")]
    //    public ToNotif ToNotif { get; set; }
    //}

    //public class Deferred
    //{
    //    [JsonPropertyName("uri")]
    //    public string Uri { get; set; }
    //}

    //public class Metadata
    //{
    //    [JsonPropertyName("id")]
    //    public string Id { get; set; }

    //    [JsonPropertyName("uri")]
    //    public string Uri { get; set; }

    //    [JsonPropertyName("type")]
    //    public string Type { get; set; }
    //}

    public class FaultResultCreate
    {
        [JsonPropertyName("d")]
        public FaultResult D { get; set; }
    }

    //public class ToItemActivity
    //{
    //    [JsonPropertyName("__deferred")]
    //    public Deferred Deferred { get; set; }
    //}

    //public class ToItemCause
    //{
    //    [JsonPropertyName("__deferred")]
    //    public Deferred Deferred { get; set; }
    //}

    //public class ToNotif
    //{
    //    [JsonPropertyName("__deferred")]
    //    public Deferred Deferred { get; set; }
    //}


}
