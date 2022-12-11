namespace GMM.Application.Models
{
    public class ModelActivity
    {
        public Guid IdActivity { get; set; }
        public int MaintNotificationActivity { get; set; }
        public int MaintenanceNotification { get; set; }
        public int MaintenanceNotificationItem { get; set; }
        public int MaintNotifActivitySortNumber { get; set; }
        public string MaintNotifActyTxt { get; set; }
        public string MaintNotifActivityCodeGroup { get; set; }
        public string NotifActivityCodeGroupText { get; set; }
        public int MaintNotificationActivityCode { get; set; }
        public string NotifActivityCodeText { get; set; }
        public DateTime PlannedStartDate { get; set; }
        public string PlannedStartTime { get; set; }
        public string PlannedEndDate { get; set; }
        public string PlannedEndTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
