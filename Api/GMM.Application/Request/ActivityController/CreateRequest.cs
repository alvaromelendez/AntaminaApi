using GMM.Application.Models;

namespace GMM.Application.Request.ActivityController
{
    public class CreateActivityRequest
    {
        public string MaintNotificationActivity { get; set; }
        public string MaintenanceNotification { get; set; }
        public string MaintenanceNotificationItem { get; set; }
        public string MaintNotifActivitySortNumber { get; set; }
        public string MaintNotifActyTxt { get; set; }
        public string MaintNotifActivityCodeGroup { get; set; }
        public string NotifActivityCodeGroupText { get; set; }
        public string MaintNotificationActivityCode { get; set; }
        public string NotifActivityCodeText { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public string PlannedStartTime { get; set; }
        public object PlannedEndDate { get; set; }
        public string PlannedEndTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
