using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class OperationSingleDetail
    {
        [JsonProperty("__metadata")]
        public OperationSingleMetadata Metadata { get; set; }

        [JsonProperty("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonProperty("MaintenanceOrderOperation")]
        public string MaintenanceOrderOperation { get; set; }

        [JsonProperty("MaintenanceOrderSubOperation")]
        public string MaintenanceOrderSubOperation { get; set; }

        [JsonProperty("OperationControlKey")]
        public string OperationControlKey { get; set; }

        [JsonProperty("OperationWorkCenterInternalID")]
        public string OperationWorkCenterInternalID { get; set; }

        [JsonProperty("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonProperty("Plant")]
        public string Plant { get; set; }

        [JsonProperty("OperationStandardTextCode")]
        public string OperationStandardTextCode { get; set; }

        [JsonProperty("OperationDescription")]
        public string OperationDescription { get; set; }

        [JsonProperty("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonProperty("MaintenanceOrderRoutingNode")]
        public string MaintenanceOrderRoutingNode { get; set; }

        [JsonProperty("SuperiorOperationInternalID")]
        public string SuperiorOperationInternalID { get; set; }

        [JsonProperty("OperationWorkCenterTypeCode")]
        public string OperationWorkCenterTypeCode { get; set; }

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("NumberOfTimeTickets")]
        public string NumberOfTimeTickets { get; set; }

        [JsonProperty("OperationPurgInfoRecdSearchTxt")]
        public string OperationPurgInfoRecdSearchTxt { get; set; }

        [JsonProperty("OperationSupplier")]
        public string OperationSupplier { get; set; }

        [JsonProperty("OpExternalProcessingPrice")]
        public string OpExternalProcessingPrice { get; set; }

        [JsonProperty("OpExternalProcessingCurrency")]
        public string OpExternalProcessingCurrency { get; set; }

        [JsonProperty("CostElement")]
        public string CostElement { get; set; }

        [JsonProperty("OperationPurchasingInfoRecord")]
        public string OperationPurchasingInfoRecord { get; set; }

        [JsonProperty("PurchasingOrganization")]
        public string PurchasingOrganization { get; set; }

        [JsonProperty("PurchasingGroup")]
        public string PurchasingGroup { get; set; }

        [JsonProperty("MaterialGroup")]
        public string MaterialGroup { get; set; }

        [JsonProperty("OpPurchaseOutlineAgreement")]
        public string OpPurchaseOutlineAgreement { get; set; }

        [JsonProperty("OpPurchaseOutlineAgreementItem")]
        public string OpPurchaseOutlineAgreementItem { get; set; }

        [JsonProperty("OperationRequisitionerName")]
        public string OperationRequisitionerName { get; set; }

        [JsonProperty("OperationTrackingNumber")]
        public string OperationTrackingNumber { get; set; }

        [JsonProperty("NumberOfCapacities")]
        public int NumberOfCapacities { get; set; }

        [JsonProperty("OperationWorkPercent")]
        public int OperationWorkPercent { get; set; }

        [JsonProperty("OperationCalculationControl")]
        public string OperationCalculationControl { get; set; }

        [JsonProperty("ActivityType")]
        public string ActivityType { get; set; }

        [JsonProperty("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonProperty("OperationGoodsRecipientName")]
        public string OperationGoodsRecipientName { get; set; }

        [JsonProperty("OperationUnloadingPointName")]
        public string OperationUnloadingPointName { get; set; }

        [JsonProperty("OperationPersonResponsible")]
        public string OperationPersonResponsible { get; set; }

        [JsonProperty("DeliveryTimeInDays")]
        public string DeliveryTimeInDays { get; set; }

        [JsonProperty("MaintOrderOperationDuration")]
        public string MaintOrderOperationDuration { get; set; }

        [JsonProperty("MaintOrdOperationDurationUnit")]
        public string MaintOrdOperationDurationUnit { get; set; }

        [JsonProperty("OpBscStartDateConstraintType")]
        public string OpBscStartDateConstraintType { get; set; }

        [JsonProperty("OpBscEndDateConstraintType")]
        public string OpBscEndDateConstraintType { get; set; }

        [JsonProperty("MaintOrdOperationWorkDuration")]
        public string MaintOrdOperationWorkDuration { get; set; }

        [JsonProperty("MaintOrdOpWorkDurationUnit")]
        public string MaintOrdOpWorkDurationUnit { get; set; }

        [JsonProperty("ConstraintDateForBscStartDate")]
        public object ConstraintDateForBscStartDate { get; set; }

        [JsonProperty("ConstraintTimeForBscStartTime")]
        public string ConstraintTimeForBscStartTime { get; set; }

        [JsonProperty("ConstraintDateForBscFinishDate")]
        public object ConstraintDateForBscFinishDate { get; set; }

        [JsonProperty("ConstraintTimeForBscFinishTime")]
        public string ConstraintTimeForBscFinishTime { get; set; }

        [JsonProperty("MaintOrdOperationExecutionRate")]
        public string MaintOrdOperationExecutionRate { get; set; }

        [JsonProperty("Equipment")]
        public string Equipment { get; set; }

        [JsonProperty("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonProperty("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonProperty("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonProperty("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonProperty("CostingSheet")]
        public string CostingSheet { get; set; }

        [JsonProperty("TaxJurisdiction")]
        public string TaxJurisdiction { get; set; }

        [JsonProperty("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonProperty("MaintControllingObjectClass")]
        public string MaintControllingObjectClass { get; set; }

        [JsonProperty("WrkCtrIntCapRqmtsDistr")]
        public string WrkCtrIntCapRqmtsDistr { get; set; }

        [JsonProperty("MaintOrdOperationOverheadCode")]
        public string MaintOrdOperationOverheadCode { get; set; }

        [JsonProperty("MaintOrderOperationQuantity")]
        public string MaintOrderOperationQuantity { get; set; }

        [JsonProperty("MaintOrdOperationQuantityUnit")]
        public string MaintOrdOperationQuantityUnit { get; set; }

        [JsonProperty("Assembly")]
        public string Assembly { get; set; }

        [JsonProperty("MaintOperationExecStageCode")]
        public string MaintOperationExecStageCode { get; set; }

        [JsonProperty("MaintOrdOpAssgdWBSElmntInt")]
        public string MaintOrdOpAssgdWBSElmntInt { get; set; }

        [JsonProperty("WBSElement")]
        public string WBSElement { get; set; }

        [JsonProperty("IsMarkedForDeletion")]
        public bool IsMarkedForDeletion { get; set; }

        [JsonProperty("MaintOrderOperationInternalID")]
        public string MaintOrderOperationInternalID { get; set; }

        [JsonProperty("MaintenanceObjectListItem")]
        public int MaintenanceObjectListItem { get; set; }

        [JsonProperty("PurchaseRequisition")]
        public string PurchaseRequisition { get; set; }

        [JsonProperty("PurchaseRequisitionItem")]
        public string PurchaseRequisitionItem { get; set; }

        [JsonProperty("OpErlstSchedldExecStrtDte")]
        public DateTime OpErlstSchedldExecStrtDte { get; set; }

        [JsonProperty("OpErlstSchedldExecStrtTme")]
        public string OpErlstSchedldExecStrtTme { get; set; }

        [JsonProperty("OpErlstSchedldExecEndDte")]
        public DateTime OpErlstSchedldExecEndDte { get; set; }

        [JsonProperty("OpErlstSchedldExecEndTme")]
        public string OpErlstSchedldExecEndTme { get; set; }

        [JsonProperty("OpLtstSchedldExecStrtDte")]
        public DateTime OpLtstSchedldExecStrtDte { get; set; }

        [JsonProperty("OpLtstSchedldExecStrtTme")]
        public string OpLtstSchedldExecStrtTme { get; set; }

        [JsonProperty("OpLtstSchedldExecEndDte")]
        public DateTime OpLtstSchedldExecEndDte { get; set; }

        [JsonProperty("OpLtstSchedldExecEndTme")]
        public string OpLtstSchedldExecEndTme { get; set; }

        [JsonProperty("OpActualExecutionStartDate")]
        public object OpActualExecutionStartDate { get; set; }

        [JsonProperty("OpActualExecutionStartTime")]
        public string OpActualExecutionStartTime { get; set; }

        [JsonProperty("OpActualExecutionEndDate")]
        public object OpActualExecutionEndDate { get; set; }

        [JsonProperty("OpActualExecutionEndTime")]
        public string OpActualExecutionEndTime { get; set; }

        [JsonProperty("ForecastWorkQuantity")]
        public string ForecastWorkQuantity { get; set; }

        [JsonProperty("ActualWorkQuantity")]
        public string ActualWorkQuantity { get; set; }

        [JsonProperty("MaintOrdOpProcessPhaseCode")]
        public string MaintOrdOpProcessPhaseCode { get; set; }

        [JsonProperty("MaintOrdOpProcessSubPhaseCode")]
        public string MaintOrdOpProcessSubPhaseCode { get; set; }

        [JsonProperty("to_MaintenanceOrder")]
        public OperationSingleToMaintenanceOrder ToMaintenanceOrder { get; set; }

        [JsonProperty("to_MaintOrderOpComponent")]
        public OperationSingleToMaintOrderOpComponent ToMaintOrderOpComponent { get; set; }

        [JsonProperty("to_MaintOrderOpRelationship")]
        public OperationSingleToMaintOrderOpRelationship ToMaintOrderOpRelationship { get; set; }
    }
    public class OperationSingleDeferred
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class OperationSingleMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
    public class ModelOperationFind
    {
        [JsonProperty("d")]
        public OperationSingleDetail D { get; set; }
    }
    public class OperationSingleToMaintenanceOrder
    {
        [JsonProperty("__deferred")]
        public OperationSingleDeferred Deferred { get; set; }
    }
    public class OperationSingleToMaintOrderOpComponent
    {
        [JsonProperty("__deferred")]
        public OperationSingleDeferred Deferred { get; set; }
    }
    public class OperationSingleToMaintOrderOpRelationship
    {
        [JsonProperty("__deferred")]
        public OperationSingleDeferred Deferred { get; set; }
    }


    public class OperationAllDetail
    {
        [JsonProperty("results")]
        public List<OperationAllResult> Results { get; set; }
    }
    public class OperationAllDeferred
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class OperationAllMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
    public class OperationAllResult
    {
        [JsonProperty("__metadata")]
        public OperationAllMetadata Metadata { get; set; }

        [JsonProperty("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonProperty("MaintenanceOrderOperation")]
        public string MaintenanceOrderOperation { get; set; }

        [JsonProperty("MaintenanceOrderSubOperation")]
        public string MaintenanceOrderSubOperation { get; set; }

        [JsonProperty("OperationControlKey")]
        public string OperationControlKey { get; set; }

        [JsonProperty("OperationWorkCenterInternalID")]
        public string OperationWorkCenterInternalID { get; set; }

        [JsonProperty("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonProperty("Plant")]
        public string Plant { get; set; }

        [JsonProperty("OperationStandardTextCode")]
        public string OperationStandardTextCode { get; set; }

        [JsonProperty("OperationDescription")]
        public string OperationDescription { get; set; }

        [JsonProperty("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonProperty("MaintenanceOrderRoutingNode")]
        public string MaintenanceOrderRoutingNode { get; set; }

        [JsonProperty("SuperiorOperationInternalID")]
        public string SuperiorOperationInternalID { get; set; }

        [JsonProperty("OperationWorkCenterTypeCode")]
        public string OperationWorkCenterTypeCode { get; set; }

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("NumberOfTimeTickets")]
        public string NumberOfTimeTickets { get; set; }

        [JsonProperty("OperationPurgInfoRecdSearchTxt")]
        public string OperationPurgInfoRecdSearchTxt { get; set; }

        [JsonProperty("OperationSupplier")]
        public string OperationSupplier { get; set; }

        [JsonProperty("OpExternalProcessingPrice")]
        public string OpExternalProcessingPrice { get; set; }

        [JsonProperty("OpExternalProcessingCurrency")]
        public string OpExternalProcessingCurrency { get; set; }

        [JsonProperty("CostElement")]
        public string CostElement { get; set; }

        [JsonProperty("OperationPurchasingInfoRecord")]
        public string OperationPurchasingInfoRecord { get; set; }

        [JsonProperty("PurchasingOrganization")]
        public string PurchasingOrganization { get; set; }

        [JsonProperty("PurchasingGroup")]
        public string PurchasingGroup { get; set; }

        [JsonProperty("MaterialGroup")]
        public string MaterialGroup { get; set; }

        [JsonProperty("OpPurchaseOutlineAgreement")]
        public string OpPurchaseOutlineAgreement { get; set; }

        [JsonProperty("OpPurchaseOutlineAgreementItem")]
        public string OpPurchaseOutlineAgreementItem { get; set; }

        [JsonProperty("OperationRequisitionerName")]
        public string OperationRequisitionerName { get; set; }

        [JsonProperty("OperationTrackingNumber")]
        public string OperationTrackingNumber { get; set; }

        [JsonProperty("NumberOfCapacities")]
        public int NumberOfCapacities { get; set; }

        [JsonProperty("OperationWorkPercent")]
        public int OperationWorkPercent { get; set; }

        [JsonProperty("OperationCalculationControl")]
        public string OperationCalculationControl { get; set; }

        [JsonProperty("ActivityType")]
        public string ActivityType { get; set; }

        [JsonProperty("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonProperty("OperationGoodsRecipientName")]
        public string OperationGoodsRecipientName { get; set; }

        [JsonProperty("OperationUnloadingPointName")]
        public string OperationUnloadingPointName { get; set; }

        [JsonProperty("OperationPersonResponsible")]
        public string OperationPersonResponsible { get; set; }

        [JsonProperty("DeliveryTimeInDays")]
        public string DeliveryTimeInDays { get; set; }

        [JsonProperty("MaintOrderOperationDuration")]
        public string MaintOrderOperationDuration { get; set; }

        [JsonProperty("MaintOrdOperationDurationUnit")]
        public string MaintOrdOperationDurationUnit { get; set; }

        [JsonProperty("OpBscStartDateConstraintType")]
        public string OpBscStartDateConstraintType { get; set; }

        [JsonProperty("OpBscEndDateConstraintType")]
        public string OpBscEndDateConstraintType { get; set; }

        [JsonProperty("MaintOrdOperationWorkDuration")]
        public string MaintOrdOperationWorkDuration { get; set; }

        [JsonProperty("MaintOrdOpWorkDurationUnit")]
        public string MaintOrdOpWorkDurationUnit { get; set; }

        [JsonProperty("ConstraintDateForBscStartDate")]
        public DateTime? ConstraintDateForBscStartDate { get; set; }

        [JsonProperty("ConstraintTimeForBscStartTime")]
        public string ConstraintTimeForBscStartTime { get; set; }

        [JsonProperty("ConstraintDateForBscFinishDate")]
        public object ConstraintDateForBscFinishDate { get; set; }

        [JsonProperty("ConstraintTimeForBscFinishTime")]
        public string ConstraintTimeForBscFinishTime { get; set; }

        [JsonProperty("MaintOrdOperationExecutionRate")]
        public string MaintOrdOperationExecutionRate { get; set; }

        [JsonProperty("Equipment")]
        public string Equipment { get; set; }

        [JsonProperty("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonProperty("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonProperty("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonProperty("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonProperty("CostingSheet")]
        public string CostingSheet { get; set; }

        [JsonProperty("TaxJurisdiction")]
        public string TaxJurisdiction { get; set; }

        [JsonProperty("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonProperty("MaintControllingObjectClass")]
        public string MaintControllingObjectClass { get; set; }

        [JsonProperty("WrkCtrIntCapRqmtsDistr")]
        public string WrkCtrIntCapRqmtsDistr { get; set; }

        [JsonProperty("MaintOrdOperationOverheadCode")]
        public string MaintOrdOperationOverheadCode { get; set; }

        [JsonProperty("MaintOrderOperationQuantity")]
        public string MaintOrderOperationQuantity { get; set; }

        [JsonProperty("MaintOrdOperationQuantityUnit")]
        public string MaintOrdOperationQuantityUnit { get; set; }

        [JsonProperty("Assembly")]
        public string Assembly { get; set; }

        [JsonProperty("MaintOperationExecStageCode")]
        public string MaintOperationExecStageCode { get; set; }

        [JsonProperty("MaintOrdOpAssgdWBSElmntInt")]
        public string MaintOrdOpAssgdWBSElmntInt { get; set; }

        [JsonProperty("WBSElement")]
        public string WBSElement { get; set; }

        [JsonProperty("IsMarkedForDeletion")]
        public bool IsMarkedForDeletion { get; set; }

        [JsonProperty("MaintOrderOperationInternalID")]
        public string MaintOrderOperationInternalID { get; set; }

        [JsonProperty("MaintenanceObjectListItem")]
        public int MaintenanceObjectListItem { get; set; }

        [JsonProperty("PurchaseRequisition")]
        public string PurchaseRequisition { get; set; }

        [JsonProperty("PurchaseRequisitionItem")]
        public string PurchaseRequisitionItem { get; set; }

        [JsonProperty("OpErlstSchedldExecStrtDte")]
        public DateTime OpErlstSchedldExecStrtDte { get; set; }

        [JsonProperty("OpErlstSchedldExecStrtTme")]
        public string OpErlstSchedldExecStrtTme { get; set; }

        [JsonProperty("OpErlstSchedldExecEndDte")]
        public DateTime OpErlstSchedldExecEndDte { get; set; }

        [JsonProperty("OpErlstSchedldExecEndTme")]
        public string OpErlstSchedldExecEndTme { get; set; }

        [JsonProperty("OpLtstSchedldExecStrtDte")]
        public DateTime OpLtstSchedldExecStrtDte { get; set; }

        [JsonProperty("OpLtstSchedldExecStrtTme")]
        public string OpLtstSchedldExecStrtTme { get; set; }

        [JsonProperty("OpLtstSchedldExecEndDte")]
        public DateTime OpLtstSchedldExecEndDte { get; set; }

        [JsonProperty("OpLtstSchedldExecEndTme")]
        public string OpLtstSchedldExecEndTme { get; set; }

        [JsonProperty("OpActualExecutionStartDate")]
        public DateTime OpActualExecutionStartDate { get; set; }

        [JsonProperty("OpActualExecutionStartTime")]
        public string OpActualExecutionStartTime { get; set; }

        [JsonProperty("OpActualExecutionEndDate")]
        public DateTime OpActualExecutionEndDate { get; set; }

        [JsonProperty("OpActualExecutionEndTime")]
        public string OpActualExecutionEndTime { get; set; }

        [JsonProperty("ForecastWorkQuantity")]
        public string ForecastWorkQuantity { get; set; }

        [JsonProperty("ActualWorkQuantity")]
        public string ActualWorkQuantity { get; set; }

        [JsonProperty("MaintOrdOpProcessPhaseCode")]
        public string MaintOrdOpProcessPhaseCode { get; set; }

        [JsonProperty("MaintOrdOpProcessSubPhaseCode")]
        public string MaintOrdOpProcessSubPhaseCode { get; set; }

        [JsonProperty("to_MaintenanceOrder")]
        public OperationAllToMaintenanceOrder ToMaintenanceOrder { get; set; }

        [JsonProperty("to_MaintOrderOpComponent")]
        public OperationAllToMaintOrderOpComponent ToMaintOrderOpComponent { get; set; }

        [JsonProperty("to_MaintOrderOpRelationship")]
        public OperationAllToMaintOrderOpRelationship ToMaintOrderOpRelationship { get; set; }
    }
    public class ModelOperationFindAll
    {
        [JsonProperty("d")]
        public OperationAllDetail D { get; set; }
    }
    public class OperationAllToMaintenanceOrder
    {
        [JsonProperty("__deferred")]
        public OperationAllDeferred Deferred { get; set; }
    }
    public class OperationAllToMaintOrderOpComponent
    {
        [JsonProperty("__deferred")]
        public OperationAllDeferred Deferred { get; set; }
    }
    public class OperationAllToMaintOrderOpRelationship
    {
        [JsonProperty("__deferred")]
        public OperationAllDeferred Deferred { get; set; }
    }




    public class OperationFindIdDetail
    {
        [JsonProperty("results")]
        public List<OperationFindIdResult> Results { get; set; }
    }
    public class OperationFindIdDeferred
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class OperationFindIdMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
    public class OperationFindIdResult
    {
        [JsonProperty("__metadata")]
        public OperationFindIdMetadata Metadata { get; set; }

        [JsonProperty("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonProperty("MaintenanceOrderOperation")]
        public string MaintenanceOrderOperation { get; set; }

        [JsonProperty("MaintenanceOrderSubOperation")]
        public string MaintenanceOrderSubOperation { get; set; }

        [JsonProperty("MaintenanceOrderComponent")]
        public string MaintenanceOrderComponent { get; set; }

        [JsonProperty("Reservation")]
        public string Reservation { get; set; }

        [JsonProperty("ReservationItem")]
        public string ReservationItem { get; set; }

        [JsonProperty("ReservationType")]
        public string ReservationType { get; set; }

        [JsonProperty("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonProperty("MaintOrderOperationCounter")]
        public string MaintOrderOperationCounter { get; set; }

        [JsonProperty("Product")]
        public string Product { get; set; }

        [JsonProperty("MaintOrdOperationComponentText")]
        public string MaintOrdOperationComponentText { get; set; }

        [JsonProperty("MaintOrdOpCompRequiredQuantity")]
        public string MaintOrdOpCompRequiredQuantity { get; set; }

        [JsonProperty("BaseUnit")]
        public string BaseUnit { get; set; }

        [JsonProperty("QuantityInUnitOfEntry")]
        public string QuantityInUnitOfEntry { get; set; }

        [JsonProperty("UnitOfEntry")]
        public string UnitOfEntry { get; set; }

        [JsonProperty("RequirementDate")]
        public DateTime RequirementDate { get; set; }

        [JsonProperty("RequirementTime")]
        public string RequirementTime { get; set; }

        [JsonProperty("Supplier")]
        public string Supplier { get; set; }

        [JsonProperty("Plant")]
        public string Plant { get; set; }

        [JsonProperty("StorageLocation")]
        public string StorageLocation { get; set; }

        [JsonProperty("MaintOrdOpCompItemCategory")]
        public string MaintOrdOpCompItemCategory { get; set; }

        [JsonProperty("GoodsMovementType")]
        public string GoodsMovementType { get; set; }

        [JsonProperty("ReservationIsFinallyIssued")]
        public bool ReservationIsFinallyIssued { get; set; }

        [JsonProperty("MaterialGroup")]
        public string MaterialGroup { get; set; }

        [JsonProperty("ProductTypeCode")]
        public string ProductTypeCode { get; set; }

        [JsonProperty("ServicePerformer")]
        public string ServicePerformer { get; set; }

        [JsonProperty("PerformancePeriodStartDate")]
        public object PerformancePeriodStartDate { get; set; }

        [JsonProperty("PerformancePeriodEndDate")]
        public object PerformancePeriodEndDate { get; set; }

        [JsonProperty("MaintOrderCompDebitCreditCode")]
        public string MaintOrderCompDebitCreditCode { get; set; }

        [JsonProperty("GoodsMovementIsAllowed")]
        public bool GoodsMovementIsAllowed { get; set; }

        [JsonProperty("MaintenanceOrderComponentBatch")]
        public string MaintenanceOrderComponentBatch { get; set; }

        [JsonProperty("QuantityIsFixed")]
        public bool QuantityIsFixed { get; set; }

        [JsonProperty("MaintOrdOpComponentGLAccount")]
        public string MaintOrdOpComponentGLAccount { get; set; }

        [JsonProperty("MaintOrdOpCompCostingRelevancy")]
        public string MaintOrdOpCompCostingRelevancy { get; set; }

        [JsonProperty("MaintCompAltvProdUsgeRateInPct")]
        public string MaintCompAltvProdUsgeRateInPct { get; set; }

        [JsonProperty("MaintOrderOpComponentSortText")]
        public string MaintOrderOpComponentSortText { get; set; }

        [JsonProperty("MaintOrdOpCompIsBulkProduct")]
        public bool MaintOrdOpCompIsBulkProduct { get; set; }

        [JsonProperty("MaterialProvisionType")]
        public string MaterialProvisionType { get; set; }

        [JsonProperty("MaintOrdOpCompAssgdWBSElmntInt")]
        public string MaintOrdOpCompAssgdWBSElmntInt { get; set; }

        [JsonProperty("MaintOrderOpComponentPrice")]
        public string MaintOrderOpComponentPrice { get; set; }

        [JsonProperty("MaintOrdOpComponentCurrency")]
        public string MaintOrdOpComponentCurrency { get; set; }

        [JsonProperty("MatlCompIsMarkedForBackflush")]
        public bool MatlCompIsMarkedForBackflush { get; set; }

        [JsonProperty("PurchasingGroup")]
        public string PurchasingGroup { get; set; }

        [JsonProperty("DeliveryTimeInDays")]
        public string DeliveryTimeInDays { get; set; }

        [JsonProperty("MaintOrdOpCompGdsRecipientName")]
        public string MaintOrdOpCompGdsRecipientName { get; set; }

        [JsonProperty("MaintOrdOpCompUnloadingPtTxt")]
        public string MaintOrdOpCompUnloadingPtTxt { get; set; }

        [JsonProperty("GoodsReceiptDurationInWorkDays")]
        public string GoodsReceiptDurationInWorkDays { get; set; }

        [JsonProperty("PurchasingInfoRecord")]
        public string PurchasingInfoRecord { get; set; }

        [JsonProperty("OperationLeadTimeOffset")]
        public string OperationLeadTimeOffset { get; set; }

        [JsonProperty("OpsLeadTimeOffsetUnit")]
        public string OpsLeadTimeOffsetUnit { get; set; }

        [JsonProperty("MaintOrdOpCompRequisitioner")]
        public string MaintOrdOpCompRequisitioner { get; set; }

        [JsonProperty("MaintOrdOpCompProcmtTrckgNmbr")]
        public string MaintOrdOpCompProcmtTrckgNmbr { get; set; }

        [JsonProperty("ResponsiblePurchaseOrg")]
        public string ResponsiblePurchaseOrg { get; set; }

        [JsonProperty("MaintOrdOpCompSpecialStockType")]
        public string MaintOrdOpCompSpecialStockType { get; set; }

        [JsonProperty("VariableSizeDimension1")]
        public string VariableSizeDimension1 { get; set; }

        [JsonProperty("VariableSizeDimensionUnit")]
        public string VariableSizeDimensionUnit { get; set; }

        [JsonProperty("VariableSizeCompFormulaKey")]
        public string VariableSizeCompFormulaKey { get; set; }

        [JsonProperty("VariableSizeDimension2")]
        public string VariableSizeDimension2 { get; set; }

        [JsonProperty("NumberOfVariableSizeItem")]
        public int NumberOfVariableSizeItem { get; set; }

        [JsonProperty("VariableSizeDimension3")]
        public string VariableSizeDimension3 { get; set; }

        [JsonProperty("VariableSizeItemQuantity")]
        public string VariableSizeItemQuantity { get; set; }

        [JsonProperty("VariableSizeComponentUnit")]
        public string VariableSizeComponentUnit { get; set; }

        [JsonProperty("RqmtDateIsEnteredManually")]
        public bool RqmtDateIsEnteredManually { get; set; }

        [JsonProperty("SupplierProduct")]
        public string SupplierProduct { get; set; }

        [JsonProperty("MaintOrdCompPurOutlineAgrmtItm")]
        public string MaintOrdCompPurOutlineAgrmtItm { get; set; }

        [JsonProperty("ControllingArea")]
        public string ControllingArea { get; set; }

        [JsonProperty("MaintOrderComponentInternalID")]
        public string MaintOrderComponentInternalID { get; set; }

        [JsonProperty("PurchaseRequisition")]
        public string PurchaseRequisition { get; set; }

        [JsonProperty("PurchaseRequisitionItem")]
        public string PurchaseRequisitionItem { get; set; }

        [JsonProperty("to_MaintenanceOrder")]
        public OperationFindIdToMaintenanceOrder ToMaintenanceOrder { get; set; }

        [JsonProperty("to_MaintenanceOrderOperation")]
        public OperationFindIdToMaintenanceOrderOperation ToMaintenanceOrderOperation { get; set; }
    }
    public class ModelOperationFindId
    {
        [JsonProperty("d")]
        public OperationFindIdDetail D { get; set; }
    }
    public class OperationFindIdToMaintenanceOrder
    {
        [JsonProperty("__deferred")]
        public OperationFindIdDeferred Deferred { get; set; }
    }
    public class OperationFindIdToMaintenanceOrderOperation
    {
        [JsonProperty("__deferred")]
        public OperationFindIdDeferred Deferred { get; set; }
    }
}
