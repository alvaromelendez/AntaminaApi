using System.Text.Json.Serialization;

namespace GMM.Application.Models
{
    public class ModelMaintenanceDetail
    {
        [JsonPropertyName("results")]
        public List<ModelMaintenanceResult> Results { get; set; }

        [JsonPropertyName("__next")]
        public string Next { get; set; }
    }
    public class ModelMaintenanceDeferred
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
    public class ModelMaintenanceMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
    public class ModelMaintenanceResult
    {
        [JsonPropertyName("__metadata")]
        public ModelMaintenanceMetadata Metadata { get; set; }

        [JsonPropertyName("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonPropertyName("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonPropertyName("MaintenanceOrderType")]
        public string MaintenanceOrderType { get; set; }

        [JsonPropertyName("MaintenanceOrderDesc")]
        public string MaintenanceOrderDesc { get; set; }

        [JsonPropertyName("MaintOrdBasicStartDateTime")]
        public DateTime MaintOrdBasicStartDateTime { get; set; }

        [JsonPropertyName("MaintOrdBasicEndDateTime")]
        public DateTime MaintOrdBasicEndDateTime { get; set; }

        [JsonPropertyName("MaintOrdBasicStartDate")]
        public DateTime MaintOrdBasicStartDate { get; set; }

        [JsonPropertyName("MaintOrdBasicStartTime")]
        public string MaintOrdBasicStartTime { get; set; }

        [JsonPropertyName("MaintOrdBasicEndDate")]
        public DateTime MaintOrdBasicEndDate { get; set; }

        [JsonPropertyName("MaintOrdBasicEndTime")]
        public string MaintOrdBasicEndTime { get; set; }

        [JsonPropertyName("MaintOrdSchedldBscStrtDateTime")]
        public DateTime MaintOrdSchedldBscStrtDateTime { get; set; }

        [JsonPropertyName("MaintOrdSchedldBscEndDateTime")]
        public DateTime MaintOrdSchedldBscEndDateTime { get; set; }

        [JsonPropertyName("ScheduledBasicStartDate")]
        public DateTime ScheduledBasicStartDate { get; set; }

        [JsonPropertyName("ScheduledBasicStartTime")]
        public string ScheduledBasicStartTime { get; set; }

        [JsonPropertyName("ScheduledBasicEndDate")]
        public DateTime ScheduledBasicEndDate { get; set; }

        [JsonPropertyName("ScheduledBasicEndTime")]
        public string ScheduledBasicEndTime { get; set; }

        [JsonPropertyName("MaintOrderReferenceDateTime")]
        public DateTime MaintOrderReferenceDateTime { get; set; }

        [JsonPropertyName("MaintOrderReferenceDate")]
        public DateTime MaintOrderReferenceDate { get; set; }

        [JsonPropertyName("MaintOrderReferenceTime")]
        public string MaintOrderReferenceTime { get; set; }

        [JsonPropertyName("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonPropertyName("OrdIsNotSchedldAutomatically")]
        public string OrdIsNotSchedldAutomatically { get; set; }

        [JsonPropertyName("ControllingArea")]
        public string ControllingArea { get; set; }

        [JsonPropertyName("MainWorkCenterInternalID")]
        public string MainWorkCenterInternalID { get; set; }

        [JsonPropertyName("MainWorkCenterTypeCode")]
        public string MainWorkCenterTypeCode { get; set; }

        [JsonPropertyName("MainWorkCenter")]
        public string MainWorkCenter { get; set; }

        [JsonPropertyName("MainWorkCenterPlant")]
        public string MainWorkCenterPlant { get; set; }

        [JsonPropertyName("WorkCenterInternalID")]
        public string WorkCenterInternalID { get; set; }

        [JsonPropertyName("WorkCenterTypeCode")]
        public string WorkCenterTypeCode { get; set; }

        [JsonPropertyName("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonPropertyName("MaintenancePlanningPlant")]
        public string MaintenancePlanningPlant { get; set; }

        [JsonPropertyName("MaintenancePlant")]
        public string MaintenancePlant { get; set; }

        [JsonPropertyName("Assembly")]
        public string Assembly { get; set; }

        [JsonPropertyName("MaintOrdProcessPhaseCode")]
        public string MaintOrdProcessPhaseCode { get; set; }

        [JsonPropertyName("MaintOrdProcessSubPhaseCode")]
        public string MaintOrdProcessSubPhaseCode { get; set; }

        [JsonPropertyName("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonPropertyName("ReferenceElement")]
        public string ReferenceElement { get; set; }

        [JsonPropertyName("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonPropertyName("AdditionalDeviceData")]
        public string AdditionalDeviceData { get; set; }

        [JsonPropertyName("Equipment")]
        public string Equipment { get; set; }

        [JsonPropertyName("EquipmentName")]
        public string EquipmentName { get; set; }

        [JsonPropertyName("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonPropertyName("MaintenanceOrderPlanningCode")]
        public string MaintenanceOrderPlanningCode { get; set; }

        [JsonPropertyName("MaintenancePlannerGroup")]
        public string MaintenancePlannerGroup { get; set; }

        [JsonPropertyName("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonPropertyName("MaintPriority")]
        public string MaintPriority { get; set; }

        [JsonPropertyName("MaintPriorityType")]
        public string MaintPriorityType { get; set; }

        [JsonPropertyName("OrderProcessingGroup")]
        public string OrderProcessingGroup { get; set; }

        [JsonPropertyName("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonPropertyName("ResponsibleCostCenter")]
        public string ResponsibleCostCenter { get; set; }

        [JsonPropertyName("MaintenanceRevision")]
        public string MaintenanceRevision { get; set; }

        [JsonPropertyName("SerialNumber")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("SuperiorProjectNetwork")]
        public string SuperiorProjectNetwork { get; set; }

        [JsonPropertyName("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonPropertyName("WBSElementInternalID")]
        public string WBSElementInternalID { get; set; }

        [JsonPropertyName("ControllingObjectClass")]
        public string ControllingObjectClass { get; set; }

        [JsonPropertyName("MaintenanceOrderInternalID")]
        public string MaintenanceOrderInternalID { get; set; }

        [JsonPropertyName("MaintenanceObjectList")]
        public string MaintenanceObjectList { get; set; }

        [JsonPropertyName("MaintObjectLocAcctAssgmtNmbr")]
        public string MaintObjectLocAcctAssgmtNmbr { get; set; }

        [JsonPropertyName("AssetLocation")]
        public string AssetLocation { get; set; }

        [JsonPropertyName("AssetRoom")]
        public string AssetRoom { get; set; }

        [JsonPropertyName("PlantSection")]
        public string PlantSection { get; set; }

        [JsonPropertyName("ABCIndicator")]
        public string ABCIndicator { get; set; }

        [JsonPropertyName("MaintObjectFreeDefinedAttrib")]
        public string MaintObjectFreeDefinedAttrib { get; set; }

        [JsonPropertyName("BasicSchedulingType")]
        public string BasicSchedulingType { get; set; }

        [JsonPropertyName("LatestAcceptableCompletionDate")]
        public DateTime? LatestAcceptableCompletionDate { get; set; }

        [JsonPropertyName("MaintOrdPersonResponsible")]
        public string MaintOrdPersonResponsible { get; set; }

        [JsonPropertyName("LastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonPropertyName("CreatedByUser")]
        public string CreatedByUser { get; set; }

        [JsonPropertyName("LocAcctAssgmtWBSElmntIntID")]
        public string LocAcctAssgmtWBSElmntIntID { get; set; }

        [JsonPropertyName("TechnicalObject")]
        public string TechnicalObject { get; set; }

        [JsonPropertyName("TechnicalObjectLabel")]
        public string TechnicalObjectLabel { get; set; }

        [JsonPropertyName("TechObjIsEquipOrFuncnlLoc")]
        public string TechObjIsEquipOrFuncnlLoc { get; set; }

        [JsonPropertyName("to_MaintenanceOrderOperation")]
        public ModelMaintenanceToMaintenanceOrderOperation ToMaintenanceOrderOperation { get; set; }

        [JsonPropertyName("to_MaintOrderObjectListItem")]
        public ModelMaintenanceToMaintOrderObjectListItem ToMaintOrderObjectListItem { get; set; }
    }
    public class ModelMaintenanceFindAll
    {
        [JsonPropertyName("d")]
        public ModelMaintenanceDetail D { get; set; }
    }
    public class ModelMaintenanceToMaintenanceOrderOperation
    {
        [JsonPropertyName("__deferred")]
        public ModelMaintenanceDeferred Deferred { get; set; }
    }
    public class ModelMaintenanceToMaintOrderObjectListItem
    {
        [JsonPropertyName("__deferred")]
        public ModelMaintenanceDeferred Deferred { get; set; }
    }

    public class ModelMaintenanceData
    {
        [JsonPropertyName("__metadata")]
        public ModelMaintenanceMetadata Metadata { get; set; }

        [JsonPropertyName("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonPropertyName("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonPropertyName("MaintenanceOrderType")]
        public string MaintenanceOrderType { get; set; }

        [JsonPropertyName("MaintenanceOrderDesc")]
        public string MaintenanceOrderDesc { get; set; }

        [JsonPropertyName("MaintOrdBasicStartDateTime")]
        public DateTime MaintOrdBasicStartDateTime { get; set; }

        [JsonPropertyName("MaintOrdBasicEndDateTime")]
        public DateTime MaintOrdBasicEndDateTime { get; set; }

        [JsonPropertyName("MaintOrdBasicStartDate")]
        public DateTime MaintOrdBasicStartDate { get; set; }

        [JsonPropertyName("MaintOrdBasicStartTime")]
        public string MaintOrdBasicStartTime { get; set; }

        [JsonPropertyName("MaintOrdBasicEndDate")]
        public DateTime MaintOrdBasicEndDate { get; set; }

        [JsonPropertyName("MaintOrdBasicEndTime")]
        public string MaintOrdBasicEndTime { get; set; }

        [JsonPropertyName("MaintOrdSchedldBscStrtDateTime")]
        public DateTime MaintOrdSchedldBscStrtDateTime { get; set; }

        [JsonPropertyName("MaintOrdSchedldBscEndDateTime")]
        public DateTime MaintOrdSchedldBscEndDateTime { get; set; }

        [JsonPropertyName("ScheduledBasicStartDate")]
        public DateTime ScheduledBasicStartDate { get; set; }

        [JsonPropertyName("ScheduledBasicStartTime")]
        public string ScheduledBasicStartTime { get; set; }

        [JsonPropertyName("ScheduledBasicEndDate")]
        public DateTime ScheduledBasicEndDate { get; set; }

        [JsonPropertyName("ScheduledBasicEndTime")]
        public string ScheduledBasicEndTime { get; set; }

        [JsonPropertyName("MaintOrderReferenceDateTime")]
        public DateTime MaintOrderReferenceDateTime { get; set; }

        [JsonPropertyName("MaintOrderReferenceDate")]
        public DateTime MaintOrderReferenceDate { get; set; }

        [JsonPropertyName("MaintOrderReferenceTime")]
        public string MaintOrderReferenceTime { get; set; }

        [JsonPropertyName("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonPropertyName("OrdIsNotSchedldAutomatically")]
        public string OrdIsNotSchedldAutomatically { get; set; }

        [JsonPropertyName("ControllingArea")]
        public string ControllingArea { get; set; }

        [JsonPropertyName("MainWorkCenterInternalID")]
        public string MainWorkCenterInternalID { get; set; }

        [JsonPropertyName("MainWorkCenterTypeCode")]
        public string MainWorkCenterTypeCode { get; set; }

        [JsonPropertyName("MainWorkCenter")]
        public string MainWorkCenter { get; set; }

        [JsonPropertyName("MainWorkCenterPlant")]
        public string MainWorkCenterPlant { get; set; }

        [JsonPropertyName("WorkCenterInternalID")]
        public string WorkCenterInternalID { get; set; }

        [JsonPropertyName("WorkCenterTypeCode")]
        public string WorkCenterTypeCode { get; set; }

        [JsonPropertyName("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonPropertyName("MaintenancePlanningPlant")]
        public string MaintenancePlanningPlant { get; set; }

        [JsonPropertyName("MaintenancePlant")]
        public string MaintenancePlant { get; set; }

        [JsonPropertyName("Assembly")]
        public string Assembly { get; set; }

        [JsonPropertyName("MaintOrdProcessPhaseCode")]
        public string MaintOrdProcessPhaseCode { get; set; }

        [JsonPropertyName("MaintOrdProcessSubPhaseCode")]
        public string MaintOrdProcessSubPhaseCode { get; set; }

        [JsonPropertyName("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonPropertyName("ReferenceElement")]
        public string ReferenceElement { get; set; }

        [JsonPropertyName("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonPropertyName("AdditionalDeviceData")]
        public string AdditionalDeviceData { get; set; }

        [JsonPropertyName("Equipment")]
        public string Equipment { get; set; }

        [JsonPropertyName("EquipmentName")]
        public string EquipmentName { get; set; }

        [JsonPropertyName("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonPropertyName("MaintenanceOrderPlanningCode")]
        public string MaintenanceOrderPlanningCode { get; set; }

        [JsonPropertyName("MaintenancePlannerGroup")]
        public string MaintenancePlannerGroup { get; set; }

        [JsonPropertyName("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonPropertyName("MaintPriority")]
        public string MaintPriority { get; set; }

        [JsonPropertyName("MaintPriorityType")]
        public string MaintPriorityType { get; set; }

        [JsonPropertyName("OrderProcessingGroup")]
        public string OrderProcessingGroup { get; set; }

        [JsonPropertyName("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonPropertyName("ResponsibleCostCenter")]
        public string ResponsibleCostCenter { get; set; }

        [JsonPropertyName("MaintenanceRevision")]
        public string MaintenanceRevision { get; set; }

        [JsonPropertyName("SerialNumber")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("SuperiorProjectNetwork")]
        public string SuperiorProjectNetwork { get; set; }

        [JsonPropertyName("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonPropertyName("WBSElementInternalID")]
        public string WBSElementInternalID { get; set; }

        [JsonPropertyName("ControllingObjectClass")]
        public string ControllingObjectClass { get; set; }

        [JsonPropertyName("MaintenanceOrderInternalID")]
        public string MaintenanceOrderInternalID { get; set; }

        [JsonPropertyName("MaintenanceObjectList")]
        public string MaintenanceObjectList { get; set; }

        [JsonPropertyName("MaintObjectLocAcctAssgmtNmbr")]
        public string MaintObjectLocAcctAssgmtNmbr { get; set; }

        [JsonPropertyName("AssetLocation")]
        public string AssetLocation { get; set; }

        [JsonPropertyName("AssetRoom")]
        public string AssetRoom { get; set; }

        [JsonPropertyName("PlantSection")]
        public string PlantSection { get; set; }

        [JsonPropertyName("ABCIndicator")]
        public string ABCIndicator { get; set; }

        [JsonPropertyName("MaintObjectFreeDefinedAttrib")]
        public string MaintObjectFreeDefinedAttrib { get; set; }

        [JsonPropertyName("BasicSchedulingType")]
        public string BasicSchedulingType { get; set; }

        [JsonPropertyName("LatestAcceptableCompletionDate")]
        public object LatestAcceptableCompletionDate { get; set; }

        [JsonPropertyName("MaintOrdPersonResponsible")]
        public string MaintOrdPersonResponsible { get; set; }

        [JsonPropertyName("LastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonPropertyName("CreatedByUser")]
        public string CreatedByUser { get; set; }

        [JsonPropertyName("LocAcctAssgmtWBSElmntIntID")]
        public string LocAcctAssgmtWBSElmntIntID { get; set; }

        [JsonPropertyName("TechnicalObject")]
        public string TechnicalObject { get; set; }

        [JsonPropertyName("TechnicalObjectLabel")]
        public string TechnicalObjectLabel { get; set; }

        [JsonPropertyName("TechObjIsEquipOrFuncnlLoc")]
        public string TechObjIsEquipOrFuncnlLoc { get; set; }

        [JsonPropertyName("to_MaintenanceOrderOperation")]
        public ModelMaintenanceToMaintenanceOrderOperation ToMaintenanceOrderOperation { get; set; }

        [JsonPropertyName("to_MaintOrderObjectListItem")]
        public ModelMaintenanceToMaintOrderObjectListItem ToMaintOrderObjectListItem { get; set; }
    }
    public class ModelMaintenanceFindByID
    {
        [JsonPropertyName("d")]
        public ModelMaintenanceData D { get; set; }
    }
}
