using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.NotificationController;
using MediatR;

namespace GMM.Application.Handlers.Queries.NotificationController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdNotification { get; }
        public QueryFindId(Guid idNotification)
        {
            IdNotification = idNotification;
        }

        public class QueryFindIdHandler : IRequestHandler<QueryFindId, FindIdResponse>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public QueryFindIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }

            public async Task<FindIdResponse> Handle(QueryFindId request, CancellationToken cancellationToken)
            {
                //var entity = await _unitOfWork.Notifications.AsNoTracking()
                //                .FirstOrDeNotificationAsync(x => x.IdNotification == request.IdNotification);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);
                var entity = new ModelNotification()
                {
                    IdNotification = request.IdNotification,
                    MaintenanceNotification = 10000030,
                    MaintNotifInternalID = "QM000010000030",
                    NotificationText = "Test MRS",
                    MaintPriority = 4,
                    NotificationType = "Z3",
                    NotifProcessingPhase = 1,
                    NotifProcessingPhaseDesc = "Pendiente",
                    MaintPriorityDesc = "4-bajo",
                    CreationDate = Convert.ToDateTime("2022-05-10T00:00:00"),
                    LastChangeTime = "PT16H20M56S",
                    LastChangeDate = Convert.ToDateTime("2022-05-10T00:00:00"),
                    LastChangeDateTime = Convert.ToDateTime("2022-05-10T21:20:56Z"),
                    CreationTime = "PT16H16M58S",
                    ReportedByUser = "EXT_PROSSI",
                    ReporterFullName = "Pedro Rossi",
                    PersonResponsible = "",
                    MalfunctionEffect = "",
                    MalfunctionEffectText = "",
                    MalfunctionStartDate = "2022-05-10T00:00:00",
                    MalfunctionStartTime = "PT21H16M21S",
                    MalfunctionEndDate = "",
                    MalfunctionEndTime = "PT00H00M00S",
                    MaintNotificationCatalog = "D",
                    MaintNotificationCode = "",
                    MaintNotificationCodeGroup = "",
                    CatalogProfile = "1",
                    NotificationCreationDate = Convert.ToDateTime("2022-05-10T00:00:00"),
                    NotificationCreationTime = "PT21H16M21S",
                    NotificationTimeZone = "UTC",
                    RequiredStartDate = "2022-05-12T00:00:00",
                    RequiredStartTime = "PT21H16M47S",
                    RequiredEndDate = "2022-05-15T00:00:00",
                    RequiredEndTime = "PT21H16M47S",
                    LatestAcceptableCompletionDate = "",
                    MaintenanceObjectIsDown = false,
                    MaintNotificationLongText = "",
                    MaintNotifLongTextForEdit = "",
                    TechnicalObject = 10000005,
                    TechObjIsEquipOrFuncnlLoc = "EAMS_EQUI",
                    TechnicalObjectLabel = 10000005,
                    MaintenancePlanningPlant = 1101,
                    MaintenancePlannerGroup = "MIM",
                    PlantSection = "",
                    ABCIndicator = 1,
                    SuperiorTechnicalObject = "?0100000000000000181",
                    SuperiorTechnicalObjectName = "MOTOR DIESEL PRINCIPAL",
                    SuperiorObjIsEquipOrFuncnlLoc = "EAMS_FL",
                    SuperiorTechnicalObjectLabel = "F-01-01-04-A09-HT0102.SMOT.SUBMOT.MOTDPR",
                    ManufacturerPartTypeName = "",
                    TechObjIsEquipOrFuncnlLocDesc = "Equipo",
                    FunctionalLocation = "?0100000000000000181",
                    FunctionalLocationLabelName = "F-01-01-04-A09-HT0102.SMOT.SUBMOT.MOTDPR",
                    TechnicalObjectDescription = "MOTOR DIESEL PRINCIPAL - HT102",
                    AssetLocation = "",
                    LocationName = "",
                    BusinessArea = "",
                    CompanyCode = "ANTA",
                    TechnicalObjectCategory = "T",
                    TechnicalObjectType = "",
                    MainWorkCenterPlant = 1101,
                    MainWorkCenter = "MECAMIO",
                    PlantName = "Mina Yanacancha",
                    MaintenancePlannerGroupName = "",
                    MaintenancePlant = 1101,
                    LocationDescription = "",
                    MainWorkCenterText = "TECNICOS DE CAMIONES",
                    MainWorkCenterPlantName = "Mina Yanacancha",
                    MaintenancePlantName = "Mina Yanacancha",
                    PlantSectionPersonRespName = "",
                    ABCIndicatorDesc = "Medianamente Crítico",
                    PersonResponsibleName = "",
                    MaintenanceOrder = 20000021,
                    MaintenanceOrderType = "ZCOR",
                    ConcatenatedActiveSystStsName = "METR ORAS",
                    MaintenanceActivityType = "",
                    MaintObjDowntimeDurationUnit = "H",
                    MaintObjectDowntimeDuration = 0,
                    MaintenancePlan = "",
                    MaintenanceItem = "",
                    TaskListGroup = "",
                    TaskListGroupCounter = "",
                    MaintenancePlanCallNumber = 0,
                    MaintenanceTaskListType = "",
                    TaskList = "",
                    NotificationReferenceDate = Convert.ToDateTime("2022-05-10T00:00:00"),
                    NotificationReferenceTime = "PT16H20M56S",
                    NotificationCompletionDate = "",
                    CompletionTime = "PT00H00M00S",
                    AssetRoom = "",
                    MaintNotifExtReferenceNumber = "",
                    MaintNotifRejectionReasonCode = "",
                    MaintNotifRejectionRsnCodeTxt = "",
                    MaintNotifDetectionCatalog = "",
                    MaintNotifDetectionCode = "",
                    MaintNotifDetectionCodeText = "",
                    MaintNotifDetectionCodeGroup = "",
                    MaintNotifDetectionCodeGrpTxt = "",
                    MaintNotifProcessPhaseCode = "",
                    MaintNotifProcessSubPhaseCode = "",
                    EAMProcessPhaseCodeDesc = "",
                    EAMProcessSubPhaseCodeDesc = ""
                };

                FindIdResponse result = new FindIdResponse();
                result.Notification = _mapper.Map<ModelNotification>(entity);

                return result;
            }
        }
    }
}
