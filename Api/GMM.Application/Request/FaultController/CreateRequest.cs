using GMM.Application.Models;

namespace GMM.Application.Request.FaultController
{
    public class CreateFaultRequest
    {
        public string MaintenanceNotification { get; set; }
        public string MaintenanceNotificationItem { get; set; }
        public string MaintNotifItemText { get; set; }
        public string MaintNotifDamageCodeGroup { get; set; }
        public string MaintNotifDamageCodeGroupName { get; set; }
        public string MaintNotificationDamageCode { get; set; }
        public string MaintNotifDamageCodeName { get; set; }
        public string MaintNotifObjPrtCodeGroup { get; set; }
        public string MaintNotifObjPrtCodeGroupName { get; set; }
        public string MaintNotifObjPrtCode { get; set; }
        public string MaintNotifObjPrtCodeName { get; set; }
    }
}
