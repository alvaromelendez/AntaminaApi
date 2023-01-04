﻿using Newtonsoft.Json;

namespace GMM.Web.Models
{
    public class NotificationResponse
    {
        [JsonProperty("IdNotification")]
        public string IdNotification { get; set; }

        [JsonProperty("MaintenanceNotification")]
        public int MaintenanceNotification { get; set; }

        [JsonProperty("MaintNotifInternalID")]
        public string MaintNotifInternalID { get; set; }

        [JsonProperty("NotificationText")]
        public string NotificationText { get; set; }

        [JsonProperty("MaintPriority")]
        public int MaintPriority { get; set; }

        [JsonProperty("NotificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("NotifProcessingPhase")]
        public int NotifProcessingPhase { get; set; }

        [JsonProperty("NotifProcessingPhaseDesc")]
        public string NotifProcessingPhaseDesc { get; set; }

        [JsonProperty("MaintPriorityDesc")]
        public string MaintPriorityDesc { get; set; }

        [JsonProperty("CreationDate")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("LastChangeTime")]
        public string LastChangeTime { get; set; }

        [JsonProperty("LastChangeDate")]
        public DateTime LastChangeDate { get; set; }

        [JsonProperty("LastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonProperty("CreationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("ReportedByUser")]
        public string ReportedByUser { get; set; }

        [JsonProperty("ReporterFullName")]
        public string ReporterFullName { get; set; }

        [JsonProperty("PersonResponsible")]
        public string PersonResponsible { get; set; }

        [JsonProperty("MalfunctionEffect")]
        public string MalfunctionEffect { get; set; }

        [JsonProperty("MalfunctionEffectText")]
        public string MalfunctionEffectText { get; set; }

        [JsonProperty("MalfunctionStartDate")]
        public DateTime MalfunctionStartDate { get; set; }

        [JsonProperty("MalfunctionStartTime")]
        public string MalfunctionStartTime { get; set; }

        [JsonProperty("MalfunctionEndDate")]
        public string MalfunctionEndDate { get; set; }

        [JsonProperty("MalfunctionEndTime")]
        public string MalfunctionEndTime { get; set; }

        [JsonProperty("MaintNotificationCatalog")]
        public string MaintNotificationCatalog { get; set; }

        [JsonProperty("MaintNotificationCode")]
        public string MaintNotificationCode { get; set; }

        [JsonProperty("MaintNotificationCodeGroup")]
        public string MaintNotificationCodeGroup { get; set; }

        [JsonProperty("CatalogProfile")]
        public string CatalogProfile { get; set; }

        [JsonProperty("NotificationCreationDate")]
        public DateTime NotificationCreationDate { get; set; }

        [JsonProperty("NotificationCreationTime")]
        public string NotificationCreationTime { get; set; }

        [JsonProperty("NotificationTimeZone")]
        public string NotificationTimeZone { get; set; }

        [JsonProperty("RequiredStartDate")]
        public DateTime RequiredStartDate { get; set; }

        [JsonProperty("RequiredStartTime")]
        public string RequiredStartTime { get; set; }

        [JsonProperty("RequiredEndDate")]
        public DateTime RequiredEndDate { get; set; }

        [JsonProperty("RequiredEndTime")]
        public string RequiredEndTime { get; set; }

        [JsonProperty("LatestAcceptableCompletionDate")]
        public string LatestAcceptableCompletionDate { get; set; }

        [JsonProperty("MaintenanceObjectIsDown")]
        public bool MaintenanceObjectIsDown { get; set; }

        [JsonProperty("MaintNotificationLongText")]
        public string MaintNotificationLongText { get; set; }

        [JsonProperty("MaintNotifLongTextForEdit")]
        public string MaintNotifLongTextForEdit { get; set; }

        [JsonProperty("TechnicalObject")]
        public int TechnicalObject { get; set; }

        [JsonProperty("TechObjIsEquipOrFuncnlLoc")]
        public string TechObjIsEquipOrFuncnlLoc { get; set; }

        [JsonProperty("TechnicalObjectLabel")]
        public int TechnicalObjectLabel { get; set; }

        [JsonProperty("MaintenancePlanningPlant")]
        public int MaintenancePlanningPlant { get; set; }

        [JsonProperty("MaintenancePlannerGroup")]
        public string MaintenancePlannerGroup { get; set; }

        [JsonProperty("PlantSection")]
        public string PlantSection { get; set; }

        [JsonProperty("ABCIndicator")]
        public int ABCIndicator { get; set; }

        [JsonProperty("SuperiorTechnicalObject")]
        public string SuperiorTechnicalObject { get; set; }

        [JsonProperty("SuperiorTechnicalObjectName")]
        public string SuperiorTechnicalObjectName { get; set; }

        [JsonProperty("SuperiorObjIsEquipOrFuncnlLoc")]
        public string SuperiorObjIsEquipOrFuncnlLoc { get; set; }

        [JsonProperty("SuperiorTechnicalObjectLabel")]
        public string SuperiorTechnicalObjectLabel { get; set; }

        [JsonProperty("ManufacturerPartTypeName")]
        public string ManufacturerPartTypeName { get; set; }

        [JsonProperty("TechObjIsEquipOrFuncnlLocDesc")]
        public string TechObjIsEquipOrFuncnlLocDesc { get; set; }

        [JsonProperty("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonProperty("FunctionalLocationLabelName")]
        public string FunctionalLocationLabelName { get; set; }

        [JsonProperty("TechnicalObjectDescription")]
        public string TechnicalObjectDescription { get; set; }

        [JsonProperty("AssetLocation")]
        public string AssetLocation { get; set; }

        [JsonProperty("LocationName")]
        public string LocationName { get; set; }

        [JsonProperty("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonProperty("CompanyCode")]
        public string CompanyCode { get; set; }

        [JsonProperty("TechnicalObjectCategory")]
        public string TechnicalObjectCategory { get; set; }

        [JsonProperty("TechnicalObjectType")]
        public string TechnicalObjectType { get; set; }

        [JsonProperty("MainWorkCenterPlant")]
        public int MainWorkCenterPlant { get; set; }

        [JsonProperty("MainWorkCenter")]
        public string MainWorkCenter { get; set; }

        [JsonProperty("PlantName")]
        public string PlantName { get; set; }

        [JsonProperty("MaintenancePlannerGroupName")]
        public string MaintenancePlannerGroupName { get; set; }

        [JsonProperty("MaintenancePlant")]
        public int MaintenancePlant { get; set; }

        [JsonProperty("LocationDescription")]
        public string LocationDescription { get; set; }

        [JsonProperty("MainWorkCenterText")]
        public string MainWorkCenterText { get; set; }

        [JsonProperty("MainWorkCenterPlantName")]
        public string MainWorkCenterPlantName { get; set; }

        [JsonProperty("MaintenancePlantName")]
        public string MaintenancePlantName { get; set; }

        [JsonProperty("PlantSectionPersonRespName")]
        public string PlantSectionPersonRespName { get; set; }

        [JsonProperty("ABCIndicatorDesc")]
        public string ABCIndicatorDesc { get; set; }

        [JsonProperty("PersonResponsibleName")]
        public string PersonResponsibleName { get; set; }

        [JsonProperty("MaintenanceOrder")]
        public int MaintenanceOrder { get; set; }

        [JsonProperty("MaintenanceOrderType")]
        public string MaintenanceOrderType { get; set; }

        [JsonProperty("ConcatenatedActiveSystStsName")]
        public string ConcatenatedActiveSystStsName { get; set; }

        [JsonProperty("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonProperty("MaintObjDowntimeDurationUnit")]
        public string MaintObjDowntimeDurationUnit { get; set; }

        [JsonProperty("MaintObjectDowntimeDuration")]
        public double MaintObjectDowntimeDuration { get; set; }

        [JsonProperty("MaintenancePlan")]
        public string MaintenancePlan { get; set; }

        [JsonProperty("MaintenanceItem")]
        public string MaintenanceItem { get; set; }

        [JsonProperty("TaskListGroup")]
        public string TaskListGroup { get; set; }

        [JsonProperty("TaskListGroupCounter")]
        public string TaskListGroupCounter { get; set; }

        [JsonProperty("MaintenancePlanCallNumber")]
        public int MaintenancePlanCallNumber { get; set; }

        [JsonProperty("MaintenanceTaskListType")]
        public string MaintenanceTaskListType { get; set; }

        [JsonProperty("TaskList")]
        public string TaskList { get; set; }

        [JsonProperty("NotificationReferenceDate")]
        public DateTime NotificationReferenceDate { get; set; }

        [JsonProperty("NotificationReferenceTime")]
        public string NotificationReferenceTime { get; set; }

        [JsonProperty("NotificationCompletionDate")]
        public string NotificationCompletionDate { get; set; }

        [JsonProperty("CompletionTime")]
        public string CompletionTime { get; set; }

        [JsonProperty("AssetRoom")]
        public string AssetRoom { get; set; }

        [JsonProperty("MaintNotifExtReferenceNumber")]
        public string MaintNotifExtReferenceNumber { get; set; }

        [JsonProperty("MaintNotifRejectionReasonCode")]
        public string MaintNotifRejectionReasonCode { get; set; }

        [JsonProperty("MaintNotifRejectionRsnCodeTxt")]
        public string MaintNotifRejectionRsnCodeTxt { get; set; }

        [JsonProperty("MaintNotifDetectionCatalog")]
        public string MaintNotifDetectionCatalog { get; set; }

        [JsonProperty("MaintNotifDetectionCode")]
        public string MaintNotifDetectionCode { get; set; }

        [JsonProperty("MaintNotifDetectionCodeText")]
        public string MaintNotifDetectionCodeText { get; set; }

        [JsonProperty("MaintNotifDetectionCodeGroup")]
        public string MaintNotifDetectionCodeGroup { get; set; }

        [JsonProperty("MaintNotifDetectionCodeGrpTxt")]
        public string MaintNotifDetectionCodeGrpTxt { get; set; }

        [JsonProperty("MaintNotifProcessPhaseCode")]
        public string MaintNotifProcessPhaseCode { get; set; }

        [JsonProperty("MaintNotifProcessSubPhaseCode")]
        public string MaintNotifProcessSubPhaseCode { get; set; }

        [JsonProperty("EAMProcessPhaseCodeDesc")]
        public string EAMProcessPhaseCodeDesc { get; set; }

        [JsonProperty("EAMProcessSubPhaseCodeDesc")]
        public string EAMProcessSubPhaseCodeDesc { get; set; }
    }

    public class NotificationDetailResponse
    {
        [JsonProperty("Notification")]
        public NotificationResponse Notification { get; set; }
    }

}
