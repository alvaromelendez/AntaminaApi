namespace GMM.Application.Models
{
    public class ModelFault
    {
        public Guid IdFault { get; set; }
        public int MaintenanceNotification { get; set; }
        public int MaintenanceNotificationItem { get; set; }
        public string MaintNotifItemText { get; set; }
        public string MaintNotifDamageCodeGroup { get; set; }
        public string MaintNotifDamageCodeGroupName { get; set; }
        public int MaintNotificationDamageCode { get; set; }
        public string MaintNotifDamageCodeName { get; set; }
        public string MaintNotifObjPrtCodeGroup { get; set; }
        public string MaintNotifObjPrtCodeGroupName { get; set; }
        public int MaintNotifObjPrtCode { get; set; }
        public string MaintNotifObjPrtCodeName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
