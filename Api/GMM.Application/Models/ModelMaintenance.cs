using Newtonsoft.Json;

namespace GMM.Application.Models
{
    public class ModelMaintenanceDetail
    {
        [JsonProperty("results")]
        public List<ModelMaintenanceResult> Results { get; set; }

        [JsonProperty("__next")]
        public string Next { get; set; }
    }
    public class ModelMaintenanceDeferred
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class ModelMaintenanceMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
    public class ModelMaintenanceResult
    {
        [JsonProperty("__metadata")]
        public ModelMaintenanceMetadata Metadata { get; set; }

        [JsonProperty("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonProperty("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonProperty("MaintenanceOrderType")]
        public string MaintenanceOrderType { get; set; }

        [JsonProperty("MaintenanceOrderDesc")]
        public string MaintenanceOrderDesc { get; set; }

        [JsonProperty("MaintOrdBasicStartDateTime")]
        public DateTime MaintOrdBasicStartDateTime { get; set; }

        [JsonProperty("MaintOrdBasicEndDateTime")]
        public DateTime MaintOrdBasicEndDateTime { get; set; }

        [JsonProperty("MaintOrdBasicStartDate")]
        public DateTime MaintOrdBasicStartDate { get; set; }

        [JsonProperty("MaintOrdBasicStartTime")]
        public string MaintOrdBasicStartTime { get; set; }

        [JsonProperty("MaintOrdBasicEndDate")]
        public DateTime MaintOrdBasicEndDate { get; set; }

        [JsonProperty("MaintOrdBasicEndTime")]
        public string MaintOrdBasicEndTime { get; set; }

        [JsonProperty("MaintOrdSchedldBscStrtDateTime")]
        public DateTime MaintOrdSchedldBscStrtDateTime { get; set; }

        [JsonProperty("MaintOrdSchedldBscEndDateTime")]
        public DateTime MaintOrdSchedldBscEndDateTime { get; set; }

        [JsonProperty("ScheduledBasicStartDate")]
        public DateTime ScheduledBasicStartDate { get; set; }

        [JsonProperty("ScheduledBasicStartTime")]
        public string ScheduledBasicStartTime { get; set; }

        [JsonProperty("ScheduledBasicEndDate")]
        public DateTime ScheduledBasicEndDate { get; set; }

        [JsonProperty("ScheduledBasicEndTime")]
        public string ScheduledBasicEndTime { get; set; }

        [JsonProperty("MaintOrderReferenceDateTime")]
        public DateTime MaintOrderReferenceDateTime { get; set; }

        [JsonProperty("MaintOrderReferenceDate")]
        public DateTime MaintOrderReferenceDate { get; set; }

        [JsonProperty("MaintOrderReferenceTime")]
        public string MaintOrderReferenceTime { get; set; }

        [JsonProperty("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonProperty("OrdIsNotSchedldAutomatically")]
        public string OrdIsNotSchedldAutomatically { get; set; }

        [JsonProperty("ControllingArea")]
        public string ControllingArea { get; set; }

        [JsonProperty("MainWorkCenterInternalID")]
        public string MainWorkCenterInternalID { get; set; }

        [JsonProperty("MainWorkCenterTypeCode")]
        public string MainWorkCenterTypeCode { get; set; }

        [JsonProperty("MainWorkCenter")]
        public string MainWorkCenter { get; set; }

        [JsonProperty("MainWorkCenterPlant")]
        public string MainWorkCenterPlant { get; set; }

        [JsonProperty("WorkCenterInternalID")]
        public string WorkCenterInternalID { get; set; }

        [JsonProperty("WorkCenterTypeCode")]
        public string WorkCenterTypeCode { get; set; }

        [JsonProperty("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonProperty("MaintenancePlanningPlant")]
        public string MaintenancePlanningPlant { get; set; }

        [JsonProperty("MaintenancePlant")]
        public string MaintenancePlant { get; set; }

        [JsonProperty("Assembly")]
        public string Assembly { get; set; }

        [JsonProperty("MaintOrdProcessPhaseCode")]
        public string MaintOrdProcessPhaseCode { get; set; }

        [JsonProperty("MaintOrdProcessSubPhaseCode")]
        public string MaintOrdProcessSubPhaseCode { get; set; }

        [JsonProperty("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonProperty("ReferenceElement")]
        public string ReferenceElement { get; set; }

        [JsonProperty("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonProperty("AdditionalDeviceData")]
        public string AdditionalDeviceData { get; set; }

        [JsonProperty("Equipment")]
        public string Equipment { get; set; }

        [JsonProperty("EquipmentName")]
        public string EquipmentName { get; set; }

        [JsonProperty("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonProperty("MaintenanceOrderPlanningCode")]
        public string MaintenanceOrderPlanningCode { get; set; }

        [JsonProperty("MaintenancePlannerGroup")]
        public string MaintenancePlannerGroup { get; set; }

        [JsonProperty("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonProperty("MaintPriority")]
        public string MaintPriority { get; set; }

        [JsonProperty("MaintPriorityType")]
        public string MaintPriorityType { get; set; }

        [JsonProperty("OrderProcessingGroup")]
        public string OrderProcessingGroup { get; set; }

        [JsonProperty("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonProperty("ResponsibleCostCenter")]
        public string ResponsibleCostCenter { get; set; }

        [JsonProperty("MaintenanceRevision")]
        public string MaintenanceRevision { get; set; }

        [JsonProperty("SerialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("SuperiorProjectNetwork")]
        public string SuperiorProjectNetwork { get; set; }

        [JsonProperty("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonProperty("WBSElementInternalID")]
        public string WBSElementInternalID { get; set; }

        [JsonProperty("ControllingObjectClass")]
        public string ControllingObjectClass { get; set; }

        [JsonProperty("MaintenanceOrderInternalID")]
        public string MaintenanceOrderInternalID { get; set; }

        [JsonProperty("MaintenanceObjectList")]
        public string MaintenanceObjectList { get; set; }

        [JsonProperty("MaintObjectLocAcctAssgmtNmbr")]
        public string MaintObjectLocAcctAssgmtNmbr { get; set; }

        [JsonProperty("AssetLocation")]
        public string AssetLocation { get; set; }

        [JsonProperty("AssetRoom")]
        public string AssetRoom { get; set; }

        [JsonProperty("PlantSection")]
        public string PlantSection { get; set; }

        [JsonProperty("ABCIndicator")]
        public string ABCIndicator { get; set; }

        [JsonProperty("MaintObjectFreeDefinedAttrib")]
        public string MaintObjectFreeDefinedAttrib { get; set; }

        [JsonProperty("BasicSchedulingType")]
        public string BasicSchedulingType { get; set; }

        [JsonProperty("LatestAcceptableCompletionDate")]
        public DateTime? LatestAcceptableCompletionDate { get; set; }

        [JsonProperty("MaintOrdPersonResponsible")]
        public string MaintOrdPersonResponsible { get; set; }

        [JsonProperty("LastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonProperty("CreatedByUser")]
        public string CreatedByUser { get; set; }

        [JsonProperty("LocAcctAssgmtWBSElmntIntID")]
        public string LocAcctAssgmtWBSElmntIntID { get; set; }

        [JsonProperty("TechnicalObject")]
        public string TechnicalObject { get; set; }

        [JsonProperty("TechnicalObjectLabel")]
        public string TechnicalObjectLabel { get; set; }

        [JsonProperty("TechObjIsEquipOrFuncnlLoc")]
        public string TechObjIsEquipOrFuncnlLoc { get; set; }

        [JsonProperty("to_MaintenanceOrderOperation")]
        public ModelMaintenanceToMaintenanceOrderOperation ToMaintenanceOrderOperation { get; set; }

        [JsonProperty("to_MaintOrderObjectListItem")]
        public ModelMaintenanceToMaintOrderObjectListItem ToMaintOrderObjectListItem { get; set; }
    }
    public class ModelMaintenanceFindAll
    {
        [JsonProperty("d")]
        public ModelMaintenanceDetail D { get; set; }
    }
    public class ModelMaintenanceToMaintenanceOrderOperation
    {
        [JsonProperty("__deferred")]
        public ModelMaintenanceDeferred Deferred { get; set; }
    }
    public class ModelMaintenanceToMaintOrderObjectListItem
    {
        [JsonProperty("__deferred")]
        public ModelMaintenanceDeferred Deferred { get; set; }
    }

    public class ModelMaintenanceData
    {
        [JsonProperty("__metadata")]
        public ModelMaintenanceMetadata Metadata { get; set; }

        [JsonProperty("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonProperty("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonProperty("MaintenanceOrderType")]
        public string MaintenanceOrderType { get; set; }

        [JsonProperty("MaintenanceOrderDesc")]
        public string MaintenanceOrderDesc { get; set; }

        [JsonProperty("MaintOrdBasicStartDateTime")]
        public DateTime MaintOrdBasicStartDateTime { get; set; }

        [JsonProperty("MaintOrdBasicEndDateTime")]
        public DateTime MaintOrdBasicEndDateTime { get; set; }

        [JsonProperty("MaintOrdBasicStartDate")]
        public DateTime MaintOrdBasicStartDate { get; set; }

        [JsonProperty("MaintOrdBasicStartTime")]
        public string MaintOrdBasicStartTime { get; set; }

        [JsonProperty("MaintOrdBasicEndDate")]
        public DateTime MaintOrdBasicEndDate { get; set; }

        [JsonProperty("MaintOrdBasicEndTime")]
        public string MaintOrdBasicEndTime { get; set; }

        [JsonProperty("MaintOrdSchedldBscStrtDateTime")]
        public DateTime MaintOrdSchedldBscStrtDateTime { get; set; }

        [JsonProperty("MaintOrdSchedldBscEndDateTime")]
        public DateTime MaintOrdSchedldBscEndDateTime { get; set; }

        [JsonProperty("ScheduledBasicStartDate")]
        public DateTime ScheduledBasicStartDate { get; set; }

        [JsonProperty("ScheduledBasicStartTime")]
        public string ScheduledBasicStartTime { get; set; }

        [JsonProperty("ScheduledBasicEndDate")]
        public DateTime ScheduledBasicEndDate { get; set; }

        [JsonProperty("ScheduledBasicEndTime")]
        public string ScheduledBasicEndTime { get; set; }

        [JsonProperty("MaintOrderReferenceDateTime")]
        public DateTime MaintOrderReferenceDateTime { get; set; }

        [JsonProperty("MaintOrderReferenceDate")]
        public DateTime MaintOrderReferenceDate { get; set; }

        [JsonProperty("MaintOrderReferenceTime")]
        public string MaintOrderReferenceTime { get; set; }

        [JsonProperty("MaintenanceNotification")]
        public string MaintenanceNotification { get; set; }

        [JsonProperty("OrdIsNotSchedldAutomatically")]
        public string OrdIsNotSchedldAutomatically { get; set; }

        [JsonProperty("ControllingArea")]
        public string ControllingArea { get; set; }

        [JsonProperty("MainWorkCenterInternalID")]
        public string MainWorkCenterInternalID { get; set; }

        [JsonProperty("MainWorkCenterTypeCode")]
        public string MainWorkCenterTypeCode { get; set; }

        [JsonProperty("MainWorkCenter")]
        public string MainWorkCenter { get; set; }

        [JsonProperty("MainWorkCenterPlant")]
        public string MainWorkCenterPlant { get; set; }

        [JsonProperty("WorkCenterInternalID")]
        public string WorkCenterInternalID { get; set; }

        [JsonProperty("WorkCenterTypeCode")]
        public string WorkCenterTypeCode { get; set; }

        [JsonProperty("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonProperty("MaintenancePlanningPlant")]
        public string MaintenancePlanningPlant { get; set; }

        [JsonProperty("MaintenancePlant")]
        public string MaintenancePlant { get; set; }

        [JsonProperty("Assembly")]
        public string Assembly { get; set; }

        [JsonProperty("MaintOrdProcessPhaseCode")]
        public string MaintOrdProcessPhaseCode { get; set; }

        [JsonProperty("MaintOrdProcessSubPhaseCode")]
        public string MaintOrdProcessSubPhaseCode { get; set; }

        [JsonProperty("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonProperty("ReferenceElement")]
        public string ReferenceElement { get; set; }

        [JsonProperty("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonProperty("AdditionalDeviceData")]
        public string AdditionalDeviceData { get; set; }

        [JsonProperty("Equipment")]
        public string Equipment { get; set; }

        [JsonProperty("EquipmentName")]
        public string EquipmentName { get; set; }

        [JsonProperty("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonProperty("MaintenanceOrderPlanningCode")]
        public string MaintenanceOrderPlanningCode { get; set; }

        [JsonProperty("MaintenancePlannerGroup")]
        public string MaintenancePlannerGroup { get; set; }

        [JsonProperty("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonProperty("MaintPriority")]
        public string MaintPriority { get; set; }

        [JsonProperty("MaintPriorityType")]
        public string MaintPriorityType { get; set; }

        [JsonProperty("OrderProcessingGroup")]
        public string OrderProcessingGroup { get; set; }

        [JsonProperty("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonProperty("ResponsibleCostCenter")]
        public string ResponsibleCostCenter { get; set; }

        [JsonProperty("MaintenanceRevision")]
        public string MaintenanceRevision { get; set; }

        [JsonProperty("SerialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("SuperiorProjectNetwork")]
        public string SuperiorProjectNetwork { get; set; }

        [JsonProperty("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonProperty("WBSElementInternalID")]
        public string WBSElementInternalID { get; set; }

        [JsonProperty("ControllingObjectClass")]
        public string ControllingObjectClass { get; set; }

        [JsonProperty("MaintenanceOrderInternalID")]
        public string MaintenanceOrderInternalID { get; set; }

        [JsonProperty("MaintenanceObjectList")]
        public string MaintenanceObjectList { get; set; }

        [JsonProperty("MaintObjectLocAcctAssgmtNmbr")]
        public string MaintObjectLocAcctAssgmtNmbr { get; set; }

        [JsonProperty("AssetLocation")]
        public string AssetLocation { get; set; }

        [JsonProperty("AssetRoom")]
        public string AssetRoom { get; set; }

        [JsonProperty("PlantSection")]
        public string PlantSection { get; set; }

        [JsonProperty("ABCIndicator")]
        public string ABCIndicator { get; set; }

        [JsonProperty("MaintObjectFreeDefinedAttrib")]
        public string MaintObjectFreeDefinedAttrib { get; set; }

        [JsonProperty("BasicSchedulingType")]
        public string BasicSchedulingType { get; set; }

        [JsonProperty("LatestAcceptableCompletionDate")]
        public object LatestAcceptableCompletionDate { get; set; }

        [JsonProperty("MaintOrdPersonResponsible")]
        public string MaintOrdPersonResponsible { get; set; }

        [JsonProperty("LastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonProperty("CreatedByUser")]
        public string CreatedByUser { get; set; }

        [JsonProperty("LocAcctAssgmtWBSElmntIntID")]
        public string LocAcctAssgmtWBSElmntIntID { get; set; }

        [JsonProperty("TechnicalObject")]
        public string TechnicalObject { get; set; }

        [JsonProperty("TechnicalObjectLabel")]
        public string TechnicalObjectLabel { get; set; }

        [JsonProperty("TechObjIsEquipOrFuncnlLoc")]
        public string TechObjIsEquipOrFuncnlLoc { get; set; }

        [JsonProperty("to_MaintenanceOrderOperation")]
        public ModelMaintenanceToMaintenanceOrderOperation ToMaintenanceOrderOperation { get; set; }

        [JsonProperty("to_MaintOrderObjectListItem")]
        public ModelMaintenanceToMaintOrderObjectListItem ToMaintOrderObjectListItem { get; set; }
    }
    public class ModelMaintenanceFindByID
    {
        [JsonProperty("d")]
        public ModelMaintenanceData D { get; set; }
    }
}
