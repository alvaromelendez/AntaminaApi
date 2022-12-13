using System.Text.Json.Serialization;

namespace GMM.Web.Models
{
    public class NotificationResponse
    {
        [JsonPropertyName("IdNotification")]
        public string IdNotification { get; set; }

        [JsonPropertyName("MaintenanceNotification")]
        public int MaintenanceNotification { get; set; }

        [JsonPropertyName("MaintNotifInternalID")]
        public string MaintNotifInternalID { get; set; }

        [JsonPropertyName("NotificationText")]
        public string NotificationText { get; set; }

        [JsonPropertyName("MaintPriority")]
        public int MaintPriority { get; set; }

        [JsonPropertyName("NotificationType")]
        public string NotificationType { get; set; }

        [JsonPropertyName("NotifProcessingPhase")]
        public int NotifProcessingPhase { get; set; }

        [JsonPropertyName("NotifProcessingPhaseDesc")]
        public string NotifProcessingPhaseDesc { get; set; }

        [JsonPropertyName("MaintPriorityDesc")]
        public string MaintPriorityDesc { get; set; }

        [JsonPropertyName("CreationDate")]
        public DateTime CreationDate { get; set; }

        [JsonPropertyName("LastChangeTime")]
        public string LastChangeTime { get; set; }

        [JsonPropertyName("LastChangeDate")]
        public DateTime LastChangeDate { get; set; }

        [JsonPropertyName("LastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonPropertyName("CreationTime")]
        public string CreationTime { get; set; }

        [JsonPropertyName("ReportedByUser")]
        public string ReportedByUser { get; set; }

        [JsonPropertyName("ReporterFullName")]
        public string ReporterFullName { get; set; }

        [JsonPropertyName("PersonResponsible")]
        public string PersonResponsible { get; set; }

        [JsonPropertyName("MalfunctionEffect")]
        public string MalfunctionEffect { get; set; }

        [JsonPropertyName("MalfunctionEffectText")]
        public string MalfunctionEffectText { get; set; }

        [JsonPropertyName("MalfunctionStartDate")]
        public DateTime MalfunctionStartDate { get; set; }

        [JsonPropertyName("MalfunctionStartTime")]
        public string MalfunctionStartTime { get; set; }

        [JsonPropertyName("MalfunctionEndDate")]
        public string MalfunctionEndDate { get; set; }

        [JsonPropertyName("MalfunctionEndTime")]
        public string MalfunctionEndTime { get; set; }

        [JsonPropertyName("MaintNotificationCatalog")]
        public string MaintNotificationCatalog { get; set; }

        [JsonPropertyName("MaintNotificationCode")]
        public string MaintNotificationCode { get; set; }

        [JsonPropertyName("MaintNotificationCodeGroup")]
        public string MaintNotificationCodeGroup { get; set; }

        [JsonPropertyName("CatalogProfile")]
        public string CatalogProfile { get; set; }

        [JsonPropertyName("NotificationCreationDate")]
        public DateTime NotificationCreationDate { get; set; }

        [JsonPropertyName("NotificationCreationTime")]
        public string NotificationCreationTime { get; set; }

        [JsonPropertyName("NotificationTimeZone")]
        public string NotificationTimeZone { get; set; }

        [JsonPropertyName("RequiredStartDate")]
        public DateTime RequiredStartDate { get; set; }

        [JsonPropertyName("RequiredStartTime")]
        public string RequiredStartTime { get; set; }

        [JsonPropertyName("RequiredEndDate")]
        public DateTime RequiredEndDate { get; set; }

        [JsonPropertyName("RequiredEndTime")]
        public string RequiredEndTime { get; set; }

        [JsonPropertyName("LatestAcceptableCompletionDate")]
        public string LatestAcceptableCompletionDate { get; set; }

        [JsonPropertyName("MaintenanceObjectIsDown")]
        public bool MaintenanceObjectIsDown { get; set; }

        [JsonPropertyName("MaintNotificationLongText")]
        public string MaintNotificationLongText { get; set; }

        [JsonPropertyName("MaintNotifLongTextForEdit")]
        public string MaintNotifLongTextForEdit { get; set; }

        [JsonPropertyName("TechnicalObject")]
        public int TechnicalObject { get; set; }

        [JsonPropertyName("TechObjIsEquipOrFuncnlLoc")]
        public string TechObjIsEquipOrFuncnlLoc { get; set; }

        [JsonPropertyName("TechnicalObjectLabel")]
        public int TechnicalObjectLabel { get; set; }

        [JsonPropertyName("MaintenancePlanningPlant")]
        public int MaintenancePlanningPlant { get; set; }

        [JsonPropertyName("MaintenancePlannerGroup")]
        public string MaintenancePlannerGroup { get; set; }

        [JsonPropertyName("PlantSection")]
        public string PlantSection { get; set; }

        [JsonPropertyName("ABCIndicator")]
        public int ABCIndicator { get; set; }

        [JsonPropertyName("SuperiorTechnicalObject")]
        public string SuperiorTechnicalObject { get; set; }

        [JsonPropertyName("SuperiorTechnicalObjectName")]
        public string SuperiorTechnicalObjectName { get; set; }

        [JsonPropertyName("SuperiorObjIsEquipOrFuncnlLoc")]
        public string SuperiorObjIsEquipOrFuncnlLoc { get; set; }

        [JsonPropertyName("SuperiorTechnicalObjectLabel")]
        public string SuperiorTechnicalObjectLabel { get; set; }

        [JsonPropertyName("ManufacturerPartTypeName")]
        public string ManufacturerPartTypeName { get; set; }

        [JsonPropertyName("TechObjIsEquipOrFuncnlLocDesc")]
        public string TechObjIsEquipOrFuncnlLocDesc { get; set; }

        [JsonPropertyName("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonPropertyName("FunctionalLocationLabelName")]
        public string FunctionalLocationLabelName { get; set; }

        [JsonPropertyName("TechnicalObjectDescription")]
        public string TechnicalObjectDescription { get; set; }

        [JsonPropertyName("AssetLocation")]
        public string AssetLocation { get; set; }

        [JsonPropertyName("LocationName")]
        public string LocationName { get; set; }

        [JsonPropertyName("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonPropertyName("CompanyCode")]
        public string CompanyCode { get; set; }

        [JsonPropertyName("TechnicalObjectCategory")]
        public string TechnicalObjectCategory { get; set; }

        [JsonPropertyName("TechnicalObjectType")]
        public string TechnicalObjectType { get; set; }

        [JsonPropertyName("MainWorkCenterPlant")]
        public int MainWorkCenterPlant { get; set; }

        [JsonPropertyName("MainWorkCenter")]
        public string MainWorkCenter { get; set; }

        [JsonPropertyName("PlantName")]
        public string PlantName { get; set; }

        [JsonPropertyName("MaintenancePlannerGroupName")]
        public string MaintenancePlannerGroupName { get; set; }

        [JsonPropertyName("MaintenancePlant")]
        public int MaintenancePlant { get; set; }

        [JsonPropertyName("LocationDescription")]
        public string LocationDescription { get; set; }

        [JsonPropertyName("MainWorkCenterText")]
        public string MainWorkCenterText { get; set; }

        [JsonPropertyName("MainWorkCenterPlantName")]
        public string MainWorkCenterPlantName { get; set; }

        [JsonPropertyName("MaintenancePlantName")]
        public string MaintenancePlantName { get; set; }

        [JsonPropertyName("PlantSectionPersonRespName")]
        public string PlantSectionPersonRespName { get; set; }

        [JsonPropertyName("ABCIndicatorDesc")]
        public string ABCIndicatorDesc { get; set; }

        [JsonPropertyName("PersonResponsibleName")]
        public string PersonResponsibleName { get; set; }

        [JsonPropertyName("MaintenanceOrder")]
        public int MaintenanceOrder { get; set; }

        [JsonPropertyName("MaintenanceOrderType")]
        public string MaintenanceOrderType { get; set; }

        [JsonPropertyName("ConcatenatedActiveSystStsName")]
        public string ConcatenatedActiveSystStsName { get; set; }

        [JsonPropertyName("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonPropertyName("MaintObjDowntimeDurationUnit")]
        public string MaintObjDowntimeDurationUnit { get; set; }

        [JsonPropertyName("MaintObjectDowntimeDuration")]
        public double MaintObjectDowntimeDuration { get; set; }

        [JsonPropertyName("MaintenancePlan")]
        public string MaintenancePlan { get; set; }

        [JsonPropertyName("MaintenanceItem")]
        public string MaintenanceItem { get; set; }

        [JsonPropertyName("TaskListGroup")]
        public string TaskListGroup { get; set; }

        [JsonPropertyName("TaskListGroupCounter")]
        public string TaskListGroupCounter { get; set; }

        [JsonPropertyName("MaintenancePlanCallNumber")]
        public int MaintenancePlanCallNumber { get; set; }

        [JsonPropertyName("MaintenanceTaskListType")]
        public string MaintenanceTaskListType { get; set; }

        [JsonPropertyName("TaskList")]
        public string TaskList { get; set; }

        [JsonPropertyName("NotificationReferenceDate")]
        public DateTime NotificationReferenceDate { get; set; }

        [JsonPropertyName("NotificationReferenceTime")]
        public string NotificationReferenceTime { get; set; }

        [JsonPropertyName("NotificationCompletionDate")]
        public string NotificationCompletionDate { get; set; }

        [JsonPropertyName("CompletionTime")]
        public string CompletionTime { get; set; }

        [JsonPropertyName("AssetRoom")]
        public string AssetRoom { get; set; }

        [JsonPropertyName("MaintNotifExtReferenceNumber")]
        public string MaintNotifExtReferenceNumber { get; set; }

        [JsonPropertyName("MaintNotifRejectionReasonCode")]
        public string MaintNotifRejectionReasonCode { get; set; }

        [JsonPropertyName("MaintNotifRejectionRsnCodeTxt")]
        public string MaintNotifRejectionRsnCodeTxt { get; set; }

        [JsonPropertyName("MaintNotifDetectionCatalog")]
        public string MaintNotifDetectionCatalog { get; set; }

        [JsonPropertyName("MaintNotifDetectionCode")]
        public string MaintNotifDetectionCode { get; set; }

        [JsonPropertyName("MaintNotifDetectionCodeText")]
        public string MaintNotifDetectionCodeText { get; set; }

        [JsonPropertyName("MaintNotifDetectionCodeGroup")]
        public string MaintNotifDetectionCodeGroup { get; set; }

        [JsonPropertyName("MaintNotifDetectionCodeGrpTxt")]
        public string MaintNotifDetectionCodeGrpTxt { get; set; }

        [JsonPropertyName("MaintNotifProcessPhaseCode")]
        public string MaintNotifProcessPhaseCode { get; set; }

        [JsonPropertyName("MaintNotifProcessSubPhaseCode")]
        public string MaintNotifProcessSubPhaseCode { get; set; }

        [JsonPropertyName("EAMProcessPhaseCodeDesc")]
        public string EAMProcessPhaseCodeDesc { get; set; }

        [JsonPropertyName("EAMProcessSubPhaseCodeDesc")]
        public string EAMProcessSubPhaseCodeDesc { get; set; }
    }

    public class NotificationDetailResponse
    {
        [JsonPropertyName("Notification")]
        public NotificationResponse Notification { get; set; }
    }

}
