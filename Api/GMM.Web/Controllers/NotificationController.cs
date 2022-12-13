using GMM.Web.Common;
using GMM.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Completion;
using System.Diagnostics;
using System.Net.Mail;

namespace GMM.Web.Controllers
{
    public class NotificationController : Controller
    {
        private readonly IServiceClient _serviceClient;
        public NotificationController(IServiceClient serviceClient)
        {
            _serviceClient = serviceClient;
        }
        public ActionResult Index()
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("Code", "110");
            parameters.Add("Header", "0m-4vnhR8vLnwOfBydHE_w==");
            var response = _serviceClient.Send<List<NotificationResponse>>(HttpMethod.Get, "api/Notification/FindAll", parameters).Result;
            return View(response);
        }
        public ActionResult Details(string id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("Code", "110");
            parameters.Add("Header", "0m-4vnhR8vLnwOfBydHE_w==");
            var response = _serviceClient.Send<NotificationDetailResponse>(HttpMethod.Get, $"api/Notification/FindId/{id}", parameters).Result;
            return View(response.Notification);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                NotificationResponse request = new NotificationResponse()
                {
                    IdNotification = collection["IdNotification"],
                    MaintenanceNotification = Convert.ToInt32(collection["MaintenanceNotification"]),
                    MaintNotifInternalID = collection["MaintNotifInternalID"],
                    NotificationText = collection["NotificationText"],
                    MaintPriority = Convert.ToInt32(collection["MaintPriority"]),
                    NotificationType = collection["NotificationType"],
                    NotifProcessingPhase = Convert.ToInt32(collection["NotifProcessingPhase"]),
                    NotifProcessingPhaseDesc = collection["NotifProcessingPhaseDesc"],
                    MaintPriorityDesc = collection["MaintPriorityDesc"],
                    CreationDate = Convert.ToDateTime(collection["CreationDate"]),
                    LastChangeTime = collection["LastChangeTime"],
                    LastChangeDate = Convert.ToDateTime(collection["LastChangeDate"]),
                    LastChangeDateTime = Convert.ToDateTime(collection["LastChangeDateTime"]),
                    CreationTime = collection["CreationTime"],
                    ReportedByUser = collection["ReportedByUser"],
                    ReporterFullName = collection["ReporterFullName"],
                    PersonResponsible = collection["PersonResponsible"],
                    MalfunctionEffect = collection["MalfunctionEffect"],
                    MalfunctionEffectText = collection["MalfunctionEffectText"],
                    MalfunctionStartDate = Convert.ToDateTime(collection["MalfunctionStartDate"]),
                    MalfunctionStartTime = collection["MalfunctionStartTime"],
                    MalfunctionEndDate = collection["MalfunctionEndDate"],
                    MalfunctionEndTime = collection["MalfunctionEndTime"],
                    MaintNotificationCatalog = collection["MaintNotificationCatalog"],
                    MaintNotificationCode = collection["MaintNotificationCode"],
                    MaintNotificationCodeGroup = collection["MaintNotificationCodeGroup"],
                    CatalogProfile = collection["CatalogProfile"],
                    NotificationCreationDate = Convert.ToDateTime(collection["NotificationCreationDate"]),
                    NotificationCreationTime = collection["NotificationCreationTime"],
                    NotificationTimeZone = collection["NotificationTimeZone"],
                    RequiredStartDate = Convert.ToDateTime(collection["RequiredStartDate"]),
                    RequiredStartTime = collection["RequiredStartTime"],
                    RequiredEndDate = Convert.ToDateTime(collection["RequiredEndDate"]),
                    RequiredEndTime = collection["RequiredEndTime"],
                    LatestAcceptableCompletionDate = collection["LatestAcceptableCompletionDate"],
                    MaintenanceObjectIsDown = Convert.ToBoolean(collection["MaintenanceObjectIsDown"].ToString().Split(",").First()),
                    MaintNotificationLongText = collection["MaintNotificationLongText"],
                    MaintNotifLongTextForEdit = collection["MaintNotifLongTextForEdit"],
                    TechnicalObject = Convert.ToInt32(collection["TechnicalObject"]),
                    TechObjIsEquipOrFuncnlLoc = collection["TechObjIsEquipOrFuncnlLoc"],
                    TechnicalObjectLabel = Convert.ToInt32(collection["TechnicalObjectLabel"]),
                    MaintenancePlanningPlant = Convert.ToInt32(collection["MaintenancePlanningPlant"]),
                    MaintenancePlannerGroup = collection["MaintenancePlannerGroup"],
                    PlantSection = collection["PlantSection"],
                    ABCIndicator = Convert.ToInt32(collection["ABCIndicator"]),
                    SuperiorTechnicalObject = collection["SuperiorTechnicalObject"],
                    SuperiorTechnicalObjectName = collection["SuperiorTechnicalObjectName"],
                    SuperiorObjIsEquipOrFuncnlLoc = collection["SuperiorObjIsEquipOrFuncnlLoc"],
                    SuperiorTechnicalObjectLabel = collection["SuperiorTechnicalObjectLabel"],
                    ManufacturerPartTypeName = collection["ManufacturerPartTypeName"],
                    TechObjIsEquipOrFuncnlLocDesc = collection["TechObjIsEquipOrFuncnlLocDesc"],
                    FunctionalLocation = collection["FunctionalLocation"],
                    FunctionalLocationLabelName = collection["FunctionalLocationLabelName"],
                    TechnicalObjectDescription = collection["TechnicalObjectDescription"],
                    AssetLocation = collection["AssetLocation"],
                    LocationName = collection["LocationName"],
                    BusinessArea = collection["BusinessArea"],
                    CompanyCode = collection["CompanyCode"],
                    TechnicalObjectCategory = collection["TechnicalObjectCategory"],
                    TechnicalObjectType = collection["TechnicalObjectType"],
                    MainWorkCenterPlant = Convert.ToInt32(collection["MainWorkCenterPlant"]),
                    MainWorkCenter = collection["MainWorkCenter"],
                    PlantName = collection["PlantName"],
                    MaintenancePlannerGroupName = collection["MaintenancePlannerGroupName"],
                    MaintenancePlant = Convert.ToInt32(collection["MaintenancePlant"]),
                    LocationDescription = collection["LocationDescription"],
                    MainWorkCenterText = collection["MainWorkCenterText"],
                    MainWorkCenterPlantName = collection["MainWorkCenterPlantName"],
                    MaintenancePlantName = collection["MaintenancePlantName"],
                    PlantSectionPersonRespName = collection["PlantSectionPersonRespName"],
                    ABCIndicatorDesc = collection["ABCIndicatorDesc"],
                    PersonResponsibleName = collection["PersonResponsibleName"],
                    MaintenanceOrder = Convert.ToInt32(collection["MaintenanceOrder"]),
                    MaintenanceOrderType = collection["MaintenanceOrderType"],
                    ConcatenatedActiveSystStsName = collection["ConcatenatedActiveSystStsName"],
                    MaintenanceActivityType = collection["MaintenanceActivityType"],
                    MaintObjDowntimeDurationUnit = collection["MaintObjDowntimeDurationUnit"],
                    MaintObjectDowntimeDuration = Convert.ToInt32(collection["MaintObjectDowntimeDuration"]),
                    MaintenancePlan = collection["MaintenancePlan"],
                    MaintenanceItem = collection["MaintenanceItem"],
                    TaskListGroup = collection["TaskListGroup"],
                    TaskListGroupCounter = collection["TaskListGroupCounter"],
                    MaintenancePlanCallNumber = Convert.ToInt32(collection["MaintenancePlanCallNumber"]),
                    MaintenanceTaskListType = collection["MaintenanceTaskListType"],
                    TaskList = collection["TaskList"],
                    NotificationReferenceDate = Convert.ToDateTime(collection["NotificationReferenceDate"]),
                    NotificationReferenceTime = collection["NotificationReferenceTime"],
                    NotificationCompletionDate = collection["NotificationCompletionDate"],
                    CompletionTime = collection["CompletionTime"],
                    AssetRoom = collection["AssetRoom"],
                    MaintNotifExtReferenceNumber = collection["MaintNotifExtReferenceNumber"],
                    MaintNotifRejectionReasonCode = collection["MaintNotifRejectionReasonCode"],
                    MaintNotifRejectionRsnCodeTxt = collection["MaintNotifRejectionRsnCodeTxt"],
                    MaintNotifDetectionCatalog = collection["MaintNotifDetectionCatalog"],
                    MaintNotifDetectionCode = collection["MaintNotifDetectionCode"],
                    MaintNotifDetectionCodeText = collection["MaintNotifDetectionCodeText"],
                    MaintNotifDetectionCodeGroup = collection["MaintNotifDetectionCodeGroup"],
                    MaintNotifDetectionCodeGrpTxt = collection["MaintNotifDetectionCodeGrpTxt"],
                    MaintNotifProcessPhaseCode = collection["MaintNotifProcessPhaseCode"],
                    MaintNotifProcessSubPhaseCode = collection["MaintNotifProcessSubPhaseCode"],
                    EAMProcessPhaseCodeDesc = collection["EAMProcessPhaseCodeDesc"],
                    EAMProcessSubPhaseCodeDesc = collection["EAMProcessSubPhaseCodeDesc"]
                };
                var response = _serviceClient.Send(HttpMethod.Post, "api/Notification/Create", request).Result;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(string id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("Code", "110");
            parameters.Add("Header", "0m-4vnhR8vLnwOfBydHE_w==");
            var response = _serviceClient.Send<NotificationDetailResponse>(HttpMethod.Get, $"api/Notification/FindId/{id}", parameters).Result;
            return View(response.Notification);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                NotificationResponse request = new NotificationResponse()
                {
                    IdNotification = collection["IdNotification"],
                    MaintenanceNotification = Convert.ToInt32(collection["MaintenanceNotification"]),
                    MaintNotifInternalID = collection["MaintNotifInternalID"],
                    NotificationText = collection["NotificationText"],
                    MaintPriority = Convert.ToInt32(collection["MaintPriority"]),
                    NotificationType = collection["NotificationType"],
                    NotifProcessingPhase = Convert.ToInt32(collection["NotifProcessingPhase"]),
                    NotifProcessingPhaseDesc = collection["NotifProcessingPhaseDesc"],
                    MaintPriorityDesc = collection["MaintPriorityDesc"],
                    CreationDate = Convert.ToDateTime(collection["CreationDate"]),
                    LastChangeTime = collection["LastChangeTime"],
                    LastChangeDate = Convert.ToDateTime(collection["LastChangeDate"]),
                    LastChangeDateTime = Convert.ToDateTime(collection["LastChangeDateTime"]),
                    CreationTime = collection["CreationTime"],
                    ReportedByUser = collection["ReportedByUser"],
                    ReporterFullName = collection["ReporterFullName"],
                    PersonResponsible = collection["PersonResponsible"],
                    MalfunctionEffect = collection["MalfunctionEffect"],
                    MalfunctionEffectText = collection["MalfunctionEffectText"],
                    MalfunctionStartDate = Convert.ToDateTime(collection["MalfunctionStartDate"]),
                    MalfunctionStartTime = collection["MalfunctionStartTime"],
                    MalfunctionEndDate = collection["MalfunctionEndDate"],
                    MalfunctionEndTime = collection["MalfunctionEndTime"],
                    MaintNotificationCatalog = collection["MaintNotificationCatalog"],
                    MaintNotificationCode = collection["MaintNotificationCode"],
                    MaintNotificationCodeGroup = collection["MaintNotificationCodeGroup"],
                    CatalogProfile = collection["CatalogProfile"],
                    NotificationCreationDate = Convert.ToDateTime(collection["NotificationCreationDate"]),
                    NotificationCreationTime = collection["NotificationCreationTime"],
                    NotificationTimeZone = collection["NotificationTimeZone"],
                    RequiredStartDate = Convert.ToDateTime(collection["RequiredStartDate"]),
                    RequiredStartTime = collection["RequiredStartTime"],
                    RequiredEndDate = Convert.ToDateTime(collection["RequiredEndDate"]),
                    RequiredEndTime = collection["RequiredEndTime"],
                    LatestAcceptableCompletionDate = collection["LatestAcceptableCompletionDate"],
                    MaintenanceObjectIsDown = Convert.ToBoolean(collection["MaintenanceObjectIsDown"].ToString().Split(",").First()),
                    MaintNotificationLongText = collection["MaintNotificationLongText"],
                    MaintNotifLongTextForEdit = collection["MaintNotifLongTextForEdit"],
                    TechnicalObject = Convert.ToInt32(collection["TechnicalObject"]),
                    TechObjIsEquipOrFuncnlLoc = collection["TechObjIsEquipOrFuncnlLoc"],
                    TechnicalObjectLabel = Convert.ToInt32(collection["TechnicalObjectLabel"]),
                    MaintenancePlanningPlant = Convert.ToInt32(collection["MaintenancePlanningPlant"]),
                    MaintenancePlannerGroup = collection["MaintenancePlannerGroup"],
                    PlantSection = collection["PlantSection"],
                    ABCIndicator = Convert.ToInt32(collection["ABCIndicator"]),
                    SuperiorTechnicalObject = collection["SuperiorTechnicalObject"],
                    SuperiorTechnicalObjectName = collection["SuperiorTechnicalObjectName"],
                    SuperiorObjIsEquipOrFuncnlLoc = collection["SuperiorObjIsEquipOrFuncnlLoc"],
                    SuperiorTechnicalObjectLabel = collection["SuperiorTechnicalObjectLabel"],
                    ManufacturerPartTypeName = collection["ManufacturerPartTypeName"],
                    TechObjIsEquipOrFuncnlLocDesc = collection["TechObjIsEquipOrFuncnlLocDesc"],
                    FunctionalLocation = collection["FunctionalLocation"],
                    FunctionalLocationLabelName = collection["FunctionalLocationLabelName"],
                    TechnicalObjectDescription = collection["TechnicalObjectDescription"],
                    AssetLocation = collection["AssetLocation"],
                    LocationName = collection["LocationName"],
                    BusinessArea = collection["BusinessArea"],
                    CompanyCode = collection["CompanyCode"],
                    TechnicalObjectCategory = collection["TechnicalObjectCategory"],
                    TechnicalObjectType = collection["TechnicalObjectType"],
                    MainWorkCenterPlant = Convert.ToInt32(collection["MainWorkCenterPlant"]),
                    MainWorkCenter = collection["MainWorkCenter"],
                    PlantName = collection["PlantName"],
                    MaintenancePlannerGroupName = collection["MaintenancePlannerGroupName"],
                    MaintenancePlant = Convert.ToInt32(collection["MaintenancePlant"]),
                    LocationDescription = collection["LocationDescription"],
                    MainWorkCenterText = collection["MainWorkCenterText"],
                    MainWorkCenterPlantName = collection["MainWorkCenterPlantName"],
                    MaintenancePlantName = collection["MaintenancePlantName"],
                    PlantSectionPersonRespName = collection["PlantSectionPersonRespName"],
                    ABCIndicatorDesc = collection["ABCIndicatorDesc"],
                    PersonResponsibleName = collection["PersonResponsibleName"],
                    MaintenanceOrder = Convert.ToInt32(collection["MaintenanceOrder"]),
                    MaintenanceOrderType = collection["MaintenanceOrderType"],
                    ConcatenatedActiveSystStsName = collection["ConcatenatedActiveSystStsName"],
                    MaintenanceActivityType = collection["MaintenanceActivityType"],
                    MaintObjDowntimeDurationUnit = collection["MaintObjDowntimeDurationUnit"],
                    MaintObjectDowntimeDuration = Convert.ToInt32(collection["MaintObjectDowntimeDuration"]),
                    MaintenancePlan = collection["MaintenancePlan"],
                    MaintenanceItem = collection["MaintenanceItem"],
                    TaskListGroup = collection["TaskListGroup"],
                    TaskListGroupCounter = collection["TaskListGroupCounter"],
                    MaintenancePlanCallNumber = Convert.ToInt32(collection["MaintenancePlanCallNumber"]),
                    MaintenanceTaskListType = collection["MaintenanceTaskListType"],
                    TaskList = collection["TaskList"],
                    NotificationReferenceDate = Convert.ToDateTime(collection["NotificationReferenceDate"]),
                    NotificationReferenceTime = collection["NotificationReferenceTime"],
                    NotificationCompletionDate = collection["NotificationCompletionDate"],
                    CompletionTime = collection["CompletionTime"],
                    AssetRoom = collection["AssetRoom"],
                    MaintNotifExtReferenceNumber = collection["MaintNotifExtReferenceNumber"],
                    MaintNotifRejectionReasonCode = collection["MaintNotifRejectionReasonCode"],
                    MaintNotifRejectionRsnCodeTxt = collection["MaintNotifRejectionRsnCodeTxt"],
                    MaintNotifDetectionCatalog = collection["MaintNotifDetectionCatalog"],
                    MaintNotifDetectionCode = collection["MaintNotifDetectionCode"],
                    MaintNotifDetectionCodeText = collection["MaintNotifDetectionCodeText"],
                    MaintNotifDetectionCodeGroup = collection["MaintNotifDetectionCodeGroup"],
                    MaintNotifDetectionCodeGrpTxt = collection["MaintNotifDetectionCodeGrpTxt"],
                    MaintNotifProcessPhaseCode = collection["MaintNotifProcessPhaseCode"],
                    MaintNotifProcessSubPhaseCode = collection["MaintNotifProcessSubPhaseCode"],
                    EAMProcessPhaseCodeDesc = collection["EAMProcessPhaseCodeDesc"],
                    EAMProcessSubPhaseCodeDesc = collection["EAMProcessSubPhaseCodeDesc"]
                };
                var response = _serviceClient.Send(HttpMethod.Put, "api/Notification/Update", request).Result;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(string id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("Code", "110");
            parameters.Add("Header", "0m-4vnhR8vLnwOfBydHE_w==");
            var response = _serviceClient.Send<NotificationDetailResponse>(HttpMethod.Get, $"api/Notification/FindId/{id}", parameters).Result;
            return View(response.Notification);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                var parameters = new Dictionary<string, string>();
                parameters.Add("Code", "110");
                parameters.Add("Header", "0m-4vnhR8vLnwOfBydHE_w==");
                var response = _serviceClient.Send(HttpMethod.Delete, $"api/Notification/Delete/{id}", parameters).Result;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
