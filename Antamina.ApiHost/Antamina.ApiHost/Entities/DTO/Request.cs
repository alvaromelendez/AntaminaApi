namespace Antamina.ApiHost.Entities.DTO
{
    public class CreateNotificationRequest
    {
        public string NotificationText { get; set; }
        public int MaintPriority { get; set; }
        public string NotificationType { get; set; }
        public DateTime MalfunctionStartDate { get; set; }
        public string MalfunctionStartTime { get; set; }
        public string NotificationTimeZone { get; set; }
        public string TechnicalObject { get; set; }
        public string TechObjIsEquipOrFuncnlLoc { get; set; }
        public bool MaintenanceObjectIsDown { get; set; }
        public string MainWorkCenter { get; set; }
        public string ReportedByUser { get; set; }
    }
}
