using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class OperationSingleDetail
    {
        [JsonPropertyName("__metadata")]
        public OperationSingleMetadata Metadata { get; set; }

        [JsonPropertyName("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonPropertyName("MaintenanceOrderOperation")]
        public string MaintenanceOrderOperation { get; set; }

        [JsonPropertyName("MaintenanceOrderSubOperation")]
        public string MaintenanceOrderSubOperation { get; set; }

        [JsonPropertyName("OperationControlKey")]
        public string OperationControlKey { get; set; }

        [JsonPropertyName("OperationWorkCenterInternalID")]
        public string OperationWorkCenterInternalID { get; set; }

        [JsonPropertyName("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonPropertyName("Plant")]
        public string Plant { get; set; }

        [JsonPropertyName("OperationStandardTextCode")]
        public string OperationStandardTextCode { get; set; }

        [JsonPropertyName("OperationDescription")]
        public string OperationDescription { get; set; }

        [JsonPropertyName("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonPropertyName("MaintenanceOrderRoutingNode")]
        public string MaintenanceOrderRoutingNode { get; set; }

        [JsonPropertyName("SuperiorOperationInternalID")]
        public string SuperiorOperationInternalID { get; set; }

        [JsonPropertyName("OperationWorkCenterTypeCode")]
        public string OperationWorkCenterTypeCode { get; set; }

        [JsonPropertyName("Language")]
        public string Language { get; set; }

        [JsonPropertyName("NumberOfTimeTickets")]
        public string NumberOfTimeTickets { get; set; }

        [JsonPropertyName("OperationPurgInfoRecdSearchTxt")]
        public string OperationPurgInfoRecdSearchTxt { get; set; }

        [JsonPropertyName("OperationSupplier")]
        public string OperationSupplier { get; set; }

        [JsonPropertyName("OpExternalProcessingPrice")]
        public string OpExternalProcessingPrice { get; set; }

        [JsonPropertyName("OpExternalProcessingCurrency")]
        public string OpExternalProcessingCurrency { get; set; }

        [JsonPropertyName("CostElement")]
        public string CostElement { get; set; }

        [JsonPropertyName("OperationPurchasingInfoRecord")]
        public string OperationPurchasingInfoRecord { get; set; }

        [JsonPropertyName("PurchasingOrganization")]
        public string PurchasingOrganization { get; set; }

        [JsonPropertyName("PurchasingGroup")]
        public string PurchasingGroup { get; set; }

        [JsonPropertyName("MaterialGroup")]
        public string MaterialGroup { get; set; }

        [JsonPropertyName("OpPurchaseOutlineAgreement")]
        public string OpPurchaseOutlineAgreement { get; set; }

        [JsonPropertyName("OpPurchaseOutlineAgreementItem")]
        public string OpPurchaseOutlineAgreementItem { get; set; }

        [JsonPropertyName("OperationRequisitionerName")]
        public string OperationRequisitionerName { get; set; }

        [JsonPropertyName("OperationTrackingNumber")]
        public string OperationTrackingNumber { get; set; }

        [JsonPropertyName("NumberOfCapacities")]
        public int NumberOfCapacities { get; set; }

        [JsonPropertyName("OperationWorkPercent")]
        public int OperationWorkPercent { get; set; }

        [JsonPropertyName("OperationCalculationControl")]
        public string OperationCalculationControl { get; set; }

        [JsonPropertyName("ActivityType")]
        public string ActivityType { get; set; }

        [JsonPropertyName("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonPropertyName("OperationGoodsRecipientName")]
        public string OperationGoodsRecipientName { get; set; }

        [JsonPropertyName("OperationUnloadingPointName")]
        public string OperationUnloadingPointName { get; set; }

        [JsonPropertyName("OperationPersonResponsible")]
        public string OperationPersonResponsible { get; set; }

        [JsonPropertyName("DeliveryTimeInDays")]
        public string DeliveryTimeInDays { get; set; }

        [JsonPropertyName("MaintOrderOperationDuration")]
        public string MaintOrderOperationDuration { get; set; }

        [JsonPropertyName("MaintOrdOperationDurationUnit")]
        public string MaintOrdOperationDurationUnit { get; set; }

        [JsonPropertyName("OpBscStartDateConstraintType")]
        public string OpBscStartDateConstraintType { get; set; }

        [JsonPropertyName("OpBscEndDateConstraintType")]
        public string OpBscEndDateConstraintType { get; set; }

        [JsonPropertyName("MaintOrdOperationWorkDuration")]
        public string MaintOrdOperationWorkDuration { get; set; }

        [JsonPropertyName("MaintOrdOpWorkDurationUnit")]
        public string MaintOrdOpWorkDurationUnit { get; set; }

        [JsonPropertyName("ConstraintDateForBscStartDate")]
        public object ConstraintDateForBscStartDate { get; set; }

        [JsonPropertyName("ConstraintTimeForBscStartTime")]
        public string ConstraintTimeForBscStartTime { get; set; }

        [JsonPropertyName("ConstraintDateForBscFinishDate")]
        public object ConstraintDateForBscFinishDate { get; set; }

        [JsonPropertyName("ConstraintTimeForBscFinishTime")]
        public string ConstraintTimeForBscFinishTime { get; set; }

        [JsonPropertyName("MaintOrdOperationExecutionRate")]
        public string MaintOrdOperationExecutionRate { get; set; }

        [JsonPropertyName("Equipment")]
        public string Equipment { get; set; }

        [JsonPropertyName("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonPropertyName("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonPropertyName("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonPropertyName("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonPropertyName("CostingSheet")]
        public string CostingSheet { get; set; }

        [JsonPropertyName("TaxJurisdiction")]
        public string TaxJurisdiction { get; set; }

        [JsonPropertyName("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonPropertyName("MaintControllingObjectClass")]
        public string MaintControllingObjectClass { get; set; }

        [JsonPropertyName("WrkCtrIntCapRqmtsDistr")]
        public string WrkCtrIntCapRqmtsDistr { get; set; }

        [JsonPropertyName("MaintOrdOperationOverheadCode")]
        public string MaintOrdOperationOverheadCode { get; set; }

        [JsonPropertyName("MaintOrderOperationQuantity")]
        public string MaintOrderOperationQuantity { get; set; }

        [JsonPropertyName("MaintOrdOperationQuantityUnit")]
        public string MaintOrdOperationQuantityUnit { get; set; }

        [JsonPropertyName("Assembly")]
        public string Assembly { get; set; }

        [JsonPropertyName("MaintOperationExecStageCode")]
        public string MaintOperationExecStageCode { get; set; }

        [JsonPropertyName("MaintOrdOpAssgdWBSElmntInt")]
        public string MaintOrdOpAssgdWBSElmntInt { get; set; }

        [JsonPropertyName("WBSElement")]
        public string WBSElement { get; set; }

        [JsonPropertyName("IsMarkedForDeletion")]
        public bool IsMarkedForDeletion { get; set; }

        [JsonPropertyName("MaintOrderOperationInternalID")]
        public string MaintOrderOperationInternalID { get; set; }

        [JsonPropertyName("MaintenanceObjectListItem")]
        public int MaintenanceObjectListItem { get; set; }

        [JsonPropertyName("PurchaseRequisition")]
        public string PurchaseRequisition { get; set; }

        [JsonPropertyName("PurchaseRequisitionItem")]
        public string PurchaseRequisitionItem { get; set; }

        [JsonPropertyName("OpErlstSchedldExecStrtDte")]
        public DateTime OpErlstSchedldExecStrtDte { get; set; }

        [JsonPropertyName("OpErlstSchedldExecStrtTme")]
        public string OpErlstSchedldExecStrtTme { get; set; }

        [JsonPropertyName("OpErlstSchedldExecEndDte")]
        public DateTime OpErlstSchedldExecEndDte { get; set; }

        [JsonPropertyName("OpErlstSchedldExecEndTme")]
        public string OpErlstSchedldExecEndTme { get; set; }

        [JsonPropertyName("OpLtstSchedldExecStrtDte")]
        public DateTime OpLtstSchedldExecStrtDte { get; set; }

        [JsonPropertyName("OpLtstSchedldExecStrtTme")]
        public string OpLtstSchedldExecStrtTme { get; set; }

        [JsonPropertyName("OpLtstSchedldExecEndDte")]
        public DateTime OpLtstSchedldExecEndDte { get; set; }

        [JsonPropertyName("OpLtstSchedldExecEndTme")]
        public string OpLtstSchedldExecEndTme { get; set; }

        [JsonPropertyName("OpActualExecutionStartDate")]
        public object OpActualExecutionStartDate { get; set; }

        [JsonPropertyName("OpActualExecutionStartTime")]
        public string OpActualExecutionStartTime { get; set; }

        [JsonPropertyName("OpActualExecutionEndDate")]
        public object OpActualExecutionEndDate { get; set; }

        [JsonPropertyName("OpActualExecutionEndTime")]
        public string OpActualExecutionEndTime { get; set; }

        [JsonPropertyName("ForecastWorkQuantity")]
        public string ForecastWorkQuantity { get; set; }

        [JsonPropertyName("ActualWorkQuantity")]
        public string ActualWorkQuantity { get; set; }

        [JsonPropertyName("MaintOrdOpProcessPhaseCode")]
        public string MaintOrdOpProcessPhaseCode { get; set; }

        [JsonPropertyName("MaintOrdOpProcessSubPhaseCode")]
        public string MaintOrdOpProcessSubPhaseCode { get; set; }

        [JsonPropertyName("to_MaintenanceOrder")]
        public OperationSingleToMaintenanceOrder ToMaintenanceOrder { get; set; }

        [JsonPropertyName("to_MaintOrderOpComponent")]
        public OperationSingleToMaintOrderOpComponent ToMaintOrderOpComponent { get; set; }

        [JsonPropertyName("to_MaintOrderOpRelationship")]
        public OperationSingleToMaintOrderOpRelationship ToMaintOrderOpRelationship { get; set; }
    }
    public class OperationSingleDeferred
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
    public class OperationSingleMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
    public class ModelOperationFind
    {
        [JsonPropertyName("d")]
        public OperationSingleDetail D { get; set; }
    }
    public class OperationSingleToMaintenanceOrder
    {
        [JsonPropertyName("__deferred")]
        public OperationSingleDeferred Deferred { get; set; }
    }
    public class OperationSingleToMaintOrderOpComponent
    {
        [JsonPropertyName("__deferred")]
        public OperationSingleDeferred Deferred { get; set; }
    }
    public class OperationSingleToMaintOrderOpRelationship
    {
        [JsonPropertyName("__deferred")]
        public OperationSingleDeferred Deferred { get; set; }
    }


    public class OperationAllDetail
    {
        [JsonPropertyName("results")]
        public List<OperationAllResult> Results { get; set; }
    }
    public class OperationAllDeferred
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
    public class OperationAllMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
    public class OperationAllResult
    {
        [JsonPropertyName("__metadata")]
        public OperationAllMetadata Metadata { get; set; }

        [JsonPropertyName("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonPropertyName("MaintenanceOrderOperation")]
        public string MaintenanceOrderOperation { get; set; }

        [JsonPropertyName("MaintenanceOrderSubOperation")]
        public string MaintenanceOrderSubOperation { get; set; }

        [JsonPropertyName("OperationControlKey")]
        public string OperationControlKey { get; set; }

        [JsonPropertyName("OperationWorkCenterInternalID")]
        public string OperationWorkCenterInternalID { get; set; }

        [JsonPropertyName("WorkCenter")]
        public string WorkCenter { get; set; }

        [JsonPropertyName("Plant")]
        public string Plant { get; set; }

        [JsonPropertyName("OperationStandardTextCode")]
        public string OperationStandardTextCode { get; set; }

        [JsonPropertyName("OperationDescription")]
        public string OperationDescription { get; set; }

        [JsonPropertyName("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonPropertyName("MaintenanceOrderRoutingNode")]
        public string MaintenanceOrderRoutingNode { get; set; }

        [JsonPropertyName("SuperiorOperationInternalID")]
        public string SuperiorOperationInternalID { get; set; }

        [JsonPropertyName("OperationWorkCenterTypeCode")]
        public string OperationWorkCenterTypeCode { get; set; }

        [JsonPropertyName("Language")]
        public string Language { get; set; }

        [JsonPropertyName("NumberOfTimeTickets")]
        public string NumberOfTimeTickets { get; set; }

        [JsonPropertyName("OperationPurgInfoRecdSearchTxt")]
        public string OperationPurgInfoRecdSearchTxt { get; set; }

        [JsonPropertyName("OperationSupplier")]
        public string OperationSupplier { get; set; }

        [JsonPropertyName("OpExternalProcessingPrice")]
        public string OpExternalProcessingPrice { get; set; }

        [JsonPropertyName("OpExternalProcessingCurrency")]
        public string OpExternalProcessingCurrency { get; set; }

        [JsonPropertyName("CostElement")]
        public string CostElement { get; set; }

        [JsonPropertyName("OperationPurchasingInfoRecord")]
        public string OperationPurchasingInfoRecord { get; set; }

        [JsonPropertyName("PurchasingOrganization")]
        public string PurchasingOrganization { get; set; }

        [JsonPropertyName("PurchasingGroup")]
        public string PurchasingGroup { get; set; }

        [JsonPropertyName("MaterialGroup")]
        public string MaterialGroup { get; set; }

        [JsonPropertyName("OpPurchaseOutlineAgreement")]
        public string OpPurchaseOutlineAgreement { get; set; }

        [JsonPropertyName("OpPurchaseOutlineAgreementItem")]
        public string OpPurchaseOutlineAgreementItem { get; set; }

        [JsonPropertyName("OperationRequisitionerName")]
        public string OperationRequisitionerName { get; set; }

        [JsonPropertyName("OperationTrackingNumber")]
        public string OperationTrackingNumber { get; set; }

        [JsonPropertyName("NumberOfCapacities")]
        public int NumberOfCapacities { get; set; }

        [JsonPropertyName("OperationWorkPercent")]
        public int OperationWorkPercent { get; set; }

        [JsonPropertyName("OperationCalculationControl")]
        public string OperationCalculationControl { get; set; }

        [JsonPropertyName("ActivityType")]
        public string ActivityType { get; set; }

        [JsonPropertyName("OperationSystemCondition")]
        public string OperationSystemCondition { get; set; }

        [JsonPropertyName("OperationGoodsRecipientName")]
        public string OperationGoodsRecipientName { get; set; }

        [JsonPropertyName("OperationUnloadingPointName")]
        public string OperationUnloadingPointName { get; set; }

        [JsonPropertyName("OperationPersonResponsible")]
        public string OperationPersonResponsible { get; set; }

        [JsonPropertyName("DeliveryTimeInDays")]
        public string DeliveryTimeInDays { get; set; }

        [JsonPropertyName("MaintOrderOperationDuration")]
        public string MaintOrderOperationDuration { get; set; }

        [JsonPropertyName("MaintOrdOperationDurationUnit")]
        public string MaintOrdOperationDurationUnit { get; set; }

        [JsonPropertyName("OpBscStartDateConstraintType")]
        public string OpBscStartDateConstraintType { get; set; }

        [JsonPropertyName("OpBscEndDateConstraintType")]
        public string OpBscEndDateConstraintType { get; set; }

        [JsonPropertyName("MaintOrdOperationWorkDuration")]
        public string MaintOrdOperationWorkDuration { get; set; }

        [JsonPropertyName("MaintOrdOpWorkDurationUnit")]
        public string MaintOrdOpWorkDurationUnit { get; set; }

        [JsonPropertyName("ConstraintDateForBscStartDate")]
        public DateTime? ConstraintDateForBscStartDate { get; set; }

        [JsonPropertyName("ConstraintTimeForBscStartTime")]
        public string ConstraintTimeForBscStartTime { get; set; }

        [JsonPropertyName("ConstraintDateForBscFinishDate")]
        public object ConstraintDateForBscFinishDate { get; set; }

        [JsonPropertyName("ConstraintTimeForBscFinishTime")]
        public string ConstraintTimeForBscFinishTime { get; set; }

        [JsonPropertyName("MaintOrdOperationExecutionRate")]
        public string MaintOrdOperationExecutionRate { get; set; }

        [JsonPropertyName("Equipment")]
        public string Equipment { get; set; }

        [JsonPropertyName("FunctionalLocation")]
        public string FunctionalLocation { get; set; }

        [JsonPropertyName("MaintenanceActivityType")]
        public string MaintenanceActivityType { get; set; }

        [JsonPropertyName("BusinessArea")]
        public string BusinessArea { get; set; }

        [JsonPropertyName("ProfitCenter")]
        public string ProfitCenter { get; set; }

        [JsonPropertyName("CostingSheet")]
        public string CostingSheet { get; set; }

        [JsonPropertyName("TaxJurisdiction")]
        public string TaxJurisdiction { get; set; }

        [JsonPropertyName("FunctionalArea")]
        public string FunctionalArea { get; set; }

        [JsonPropertyName("MaintControllingObjectClass")]
        public string MaintControllingObjectClass { get; set; }

        [JsonPropertyName("WrkCtrIntCapRqmtsDistr")]
        public string WrkCtrIntCapRqmtsDistr { get; set; }

        [JsonPropertyName("MaintOrdOperationOverheadCode")]
        public string MaintOrdOperationOverheadCode { get; set; }

        [JsonPropertyName("MaintOrderOperationQuantity")]
        public string MaintOrderOperationQuantity { get; set; }

        [JsonPropertyName("MaintOrdOperationQuantityUnit")]
        public string MaintOrdOperationQuantityUnit { get; set; }

        [JsonPropertyName("Assembly")]
        public string Assembly { get; set; }

        [JsonPropertyName("MaintOperationExecStageCode")]
        public string MaintOperationExecStageCode { get; set; }

        [JsonPropertyName("MaintOrdOpAssgdWBSElmntInt")]
        public string MaintOrdOpAssgdWBSElmntInt { get; set; }

        [JsonPropertyName("WBSElement")]
        public string WBSElement { get; set; }

        [JsonPropertyName("IsMarkedForDeletion")]
        public bool IsMarkedForDeletion { get; set; }

        [JsonPropertyName("MaintOrderOperationInternalID")]
        public string MaintOrderOperationInternalID { get; set; }

        [JsonPropertyName("MaintenanceObjectListItem")]
        public int MaintenanceObjectListItem { get; set; }

        [JsonPropertyName("PurchaseRequisition")]
        public string PurchaseRequisition { get; set; }

        [JsonPropertyName("PurchaseRequisitionItem")]
        public string PurchaseRequisitionItem { get; set; }

        [JsonPropertyName("OpErlstSchedldExecStrtDte")]
        public DateTime OpErlstSchedldExecStrtDte { get; set; }

        [JsonPropertyName("OpErlstSchedldExecStrtTme")]
        public string OpErlstSchedldExecStrtTme { get; set; }

        [JsonPropertyName("OpErlstSchedldExecEndDte")]
        public DateTime OpErlstSchedldExecEndDte { get; set; }

        [JsonPropertyName("OpErlstSchedldExecEndTme")]
        public string OpErlstSchedldExecEndTme { get; set; }

        [JsonPropertyName("OpLtstSchedldExecStrtDte")]
        public DateTime OpLtstSchedldExecStrtDte { get; set; }

        [JsonPropertyName("OpLtstSchedldExecStrtTme")]
        public string OpLtstSchedldExecStrtTme { get; set; }

        [JsonPropertyName("OpLtstSchedldExecEndDte")]
        public DateTime OpLtstSchedldExecEndDte { get; set; }

        [JsonPropertyName("OpLtstSchedldExecEndTme")]
        public string OpLtstSchedldExecEndTme { get; set; }

        [JsonPropertyName("OpActualExecutionStartDate")]
        public DateTime OpActualExecutionStartDate { get; set; }

        [JsonPropertyName("OpActualExecutionStartTime")]
        public string OpActualExecutionStartTime { get; set; }

        [JsonPropertyName("OpActualExecutionEndDate")]
        public DateTime OpActualExecutionEndDate { get; set; }

        [JsonPropertyName("OpActualExecutionEndTime")]
        public string OpActualExecutionEndTime { get; set; }

        [JsonPropertyName("ForecastWorkQuantity")]
        public string ForecastWorkQuantity { get; set; }

        [JsonPropertyName("ActualWorkQuantity")]
        public string ActualWorkQuantity { get; set; }

        [JsonPropertyName("MaintOrdOpProcessPhaseCode")]
        public string MaintOrdOpProcessPhaseCode { get; set; }

        [JsonPropertyName("MaintOrdOpProcessSubPhaseCode")]
        public string MaintOrdOpProcessSubPhaseCode { get; set; }

        [JsonPropertyName("to_MaintenanceOrder")]
        public OperationAllToMaintenanceOrder ToMaintenanceOrder { get; set; }

        [JsonPropertyName("to_MaintOrderOpComponent")]
        public OperationAllToMaintOrderOpComponent ToMaintOrderOpComponent { get; set; }

        [JsonPropertyName("to_MaintOrderOpRelationship")]
        public OperationAllToMaintOrderOpRelationship ToMaintOrderOpRelationship { get; set; }
    }
    public class ModelOperationFindAll
    {
        [JsonPropertyName("d")]
        public OperationAllDetail D { get; set; }
    }
    public class OperationAllToMaintenanceOrder
    {
        [JsonPropertyName("__deferred")]
        public OperationAllDeferred Deferred { get; set; }
    }
    public class OperationAllToMaintOrderOpComponent
    {
        [JsonPropertyName("__deferred")]
        public OperationAllDeferred Deferred { get; set; }
    }
    public class OperationAllToMaintOrderOpRelationship
    {
        [JsonPropertyName("__deferred")]
        public OperationAllDeferred Deferred { get; set; }
    }




    public class OperationFindIdDetail
    {
        [JsonPropertyName("results")]
        public List<OperationFindIdResult> Results { get; set; }
    }
    public class OperationFindIdDeferred
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
    public class OperationFindIdMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
    public class OperationFindIdResult
    {
        [JsonPropertyName("__metadata")]
        public OperationFindIdMetadata Metadata { get; set; }

        [JsonPropertyName("MaintenanceOrder")]
        public string MaintenanceOrder { get; set; }

        [JsonPropertyName("MaintenanceOrderOperation")]
        public string MaintenanceOrderOperation { get; set; }

        [JsonPropertyName("MaintenanceOrderSubOperation")]
        public string MaintenanceOrderSubOperation { get; set; }

        [JsonPropertyName("MaintenanceOrderComponent")]
        public string MaintenanceOrderComponent { get; set; }

        [JsonPropertyName("Reservation")]
        public string Reservation { get; set; }

        [JsonPropertyName("ReservationItem")]
        public string ReservationItem { get; set; }

        [JsonPropertyName("ReservationType")]
        public string ReservationType { get; set; }

        [JsonPropertyName("MaintOrderRoutingNumber")]
        public string MaintOrderRoutingNumber { get; set; }

        [JsonPropertyName("MaintOrderOperationCounter")]
        public string MaintOrderOperationCounter { get; set; }

        [JsonPropertyName("Product")]
        public string Product { get; set; }

        [JsonPropertyName("MaintOrdOperationComponentText")]
        public string MaintOrdOperationComponentText { get; set; }

        [JsonPropertyName("MaintOrdOpCompRequiredQuantity")]
        public string MaintOrdOpCompRequiredQuantity { get; set; }

        [JsonPropertyName("BaseUnit")]
        public string BaseUnit { get; set; }

        [JsonPropertyName("QuantityInUnitOfEntry")]
        public string QuantityInUnitOfEntry { get; set; }

        [JsonPropertyName("UnitOfEntry")]
        public string UnitOfEntry { get; set; }

        [JsonPropertyName("RequirementDate")]
        public DateTime RequirementDate { get; set; }

        [JsonPropertyName("RequirementTime")]
        public string RequirementTime { get; set; }

        [JsonPropertyName("Supplier")]
        public string Supplier { get; set; }

        [JsonPropertyName("Plant")]
        public string Plant { get; set; }

        [JsonPropertyName("StorageLocation")]
        public string StorageLocation { get; set; }

        [JsonPropertyName("MaintOrdOpCompItemCategory")]
        public string MaintOrdOpCompItemCategory { get; set; }

        [JsonPropertyName("GoodsMovementType")]
        public string GoodsMovementType { get; set; }

        [JsonPropertyName("ReservationIsFinallyIssued")]
        public bool ReservationIsFinallyIssued { get; set; }

        [JsonPropertyName("MaterialGroup")]
        public string MaterialGroup { get; set; }

        [JsonPropertyName("ProductTypeCode")]
        public string ProductTypeCode { get; set; }

        [JsonPropertyName("ServicePerformer")]
        public string ServicePerformer { get; set; }

        [JsonPropertyName("PerformancePeriodStartDate")]
        public object PerformancePeriodStartDate { get; set; }

        [JsonPropertyName("PerformancePeriodEndDate")]
        public object PerformancePeriodEndDate { get; set; }

        [JsonPropertyName("MaintOrderCompDebitCreditCode")]
        public string MaintOrderCompDebitCreditCode { get; set; }

        [JsonPropertyName("GoodsMovementIsAllowed")]
        public bool GoodsMovementIsAllowed { get; set; }

        [JsonPropertyName("MaintenanceOrderComponentBatch")]
        public string MaintenanceOrderComponentBatch { get; set; }

        [JsonPropertyName("QuantityIsFixed")]
        public bool QuantityIsFixed { get; set; }

        [JsonPropertyName("MaintOrdOpComponentGLAccount")]
        public string MaintOrdOpComponentGLAccount { get; set; }

        [JsonPropertyName("MaintOrdOpCompCostingRelevancy")]
        public string MaintOrdOpCompCostingRelevancy { get; set; }

        [JsonPropertyName("MaintCompAltvProdUsgeRateInPct")]
        public string MaintCompAltvProdUsgeRateInPct { get; set; }

        [JsonPropertyName("MaintOrderOpComponentSortText")]
        public string MaintOrderOpComponentSortText { get; set; }

        [JsonPropertyName("MaintOrdOpCompIsBulkProduct")]
        public bool MaintOrdOpCompIsBulkProduct { get; set; }

        [JsonPropertyName("MaterialProvisionType")]
        public string MaterialProvisionType { get; set; }

        [JsonPropertyName("MaintOrdOpCompAssgdWBSElmntInt")]
        public string MaintOrdOpCompAssgdWBSElmntInt { get; set; }

        [JsonPropertyName("MaintOrderOpComponentPrice")]
        public string MaintOrderOpComponentPrice { get; set; }

        [JsonPropertyName("MaintOrdOpComponentCurrency")]
        public string MaintOrdOpComponentCurrency { get; set; }

        [JsonPropertyName("MatlCompIsMarkedForBackflush")]
        public bool MatlCompIsMarkedForBackflush { get; set; }

        [JsonPropertyName("PurchasingGroup")]
        public string PurchasingGroup { get; set; }

        [JsonPropertyName("DeliveryTimeInDays")]
        public string DeliveryTimeInDays { get; set; }

        [JsonPropertyName("MaintOrdOpCompGdsRecipientName")]
        public string MaintOrdOpCompGdsRecipientName { get; set; }

        [JsonPropertyName("MaintOrdOpCompUnloadingPtTxt")]
        public string MaintOrdOpCompUnloadingPtTxt { get; set; }

        [JsonPropertyName("GoodsReceiptDurationInWorkDays")]
        public string GoodsReceiptDurationInWorkDays { get; set; }

        [JsonPropertyName("PurchasingInfoRecord")]
        public string PurchasingInfoRecord { get; set; }

        [JsonPropertyName("OperationLeadTimeOffset")]
        public string OperationLeadTimeOffset { get; set; }

        [JsonPropertyName("OpsLeadTimeOffsetUnit")]
        public string OpsLeadTimeOffsetUnit { get; set; }

        [JsonPropertyName("MaintOrdOpCompRequisitioner")]
        public string MaintOrdOpCompRequisitioner { get; set; }

        [JsonPropertyName("MaintOrdOpCompProcmtTrckgNmbr")]
        public string MaintOrdOpCompProcmtTrckgNmbr { get; set; }

        [JsonPropertyName("ResponsiblePurchaseOrg")]
        public string ResponsiblePurchaseOrg { get; set; }

        [JsonPropertyName("MaintOrdOpCompSpecialStockType")]
        public string MaintOrdOpCompSpecialStockType { get; set; }

        [JsonPropertyName("VariableSizeDimension1")]
        public string VariableSizeDimension1 { get; set; }

        [JsonPropertyName("VariableSizeDimensionUnit")]
        public string VariableSizeDimensionUnit { get; set; }

        [JsonPropertyName("VariableSizeCompFormulaKey")]
        public string VariableSizeCompFormulaKey { get; set; }

        [JsonPropertyName("VariableSizeDimension2")]
        public string VariableSizeDimension2 { get; set; }

        [JsonPropertyName("NumberOfVariableSizeItem")]
        public int NumberOfVariableSizeItem { get; set; }

        [JsonPropertyName("VariableSizeDimension3")]
        public string VariableSizeDimension3 { get; set; }

        [JsonPropertyName("VariableSizeItemQuantity")]
        public string VariableSizeItemQuantity { get; set; }

        [JsonPropertyName("VariableSizeComponentUnit")]
        public string VariableSizeComponentUnit { get; set; }

        [JsonPropertyName("RqmtDateIsEnteredManually")]
        public bool RqmtDateIsEnteredManually { get; set; }

        [JsonPropertyName("SupplierProduct")]
        public string SupplierProduct { get; set; }

        [JsonPropertyName("MaintOrdCompPurOutlineAgrmtItm")]
        public string MaintOrdCompPurOutlineAgrmtItm { get; set; }

        [JsonPropertyName("ControllingArea")]
        public string ControllingArea { get; set; }

        [JsonPropertyName("MaintOrderComponentInternalID")]
        public string MaintOrderComponentInternalID { get; set; }

        [JsonPropertyName("PurchaseRequisition")]
        public string PurchaseRequisition { get; set; }

        [JsonPropertyName("PurchaseRequisitionItem")]
        public string PurchaseRequisitionItem { get; set; }

        [JsonPropertyName("to_MaintenanceOrder")]
        public OperationFindIdToMaintenanceOrder ToMaintenanceOrder { get; set; }

        [JsonPropertyName("to_MaintenanceOrderOperation")]
        public OperationFindIdToMaintenanceOrderOperation ToMaintenanceOrderOperation { get; set; }
    }
    public class ModelOperationFindId
    {
        [JsonPropertyName("d")]
        public OperationFindIdDetail D { get; set; }
    }
    public class OperationFindIdToMaintenanceOrder
    {
        [JsonPropertyName("__deferred")]
        public OperationFindIdDeferred Deferred { get; set; }
    }
    public class OperationFindIdToMaintenanceOrderOperation
    {
        [JsonPropertyName("__deferred")]
        public OperationFindIdDeferred Deferred { get; set; }
    }
}
