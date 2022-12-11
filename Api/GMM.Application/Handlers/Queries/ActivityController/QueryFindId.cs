using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.ActivityController;
using MediatR;

namespace GMM.Application.Handlers.Queries.ActivityController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdActivity { get; }
        public QueryFindId(Guid idActivity)
        {
            IdActivity = idActivity;
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
                //var entity = await _unitOfWork.Activitys.AsNoTracking()
                //                .FirstOrDeActivityAsync(x => x.IdActivity == request.IdActivity);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);
                var entity = new ModelActivity()
                {
                    IdActivity = request.IdActivity,
                    MaintNotificationActivity = 1,
                    MaintenanceNotification = 10000381,
                    MaintenanceNotificationItem = 1,
                    MaintNotifActivitySortNumber = 6,
                    MaintNotifActyTxt = "TEST Actividades a realizar",
                    MaintNotifActivityCodeGroup = "PM1",
                    NotifActivityCodeGroupText = "Actividades de mantenimiento",
                    MaintNotificationActivityCode = 1,
                    NotifActivityCodeText = "Actividad 1",
                    PlannedStartDate = Convert.ToDateTime("2022-10-02T00:00:00"),
                    PlannedStartTime = "PT07H00M00S",
                    PlannedEndDate = "",
                    PlannedEndTime = "PT00H00M00S",
                    IsDeleted = false
                };

                FindIdResponse result = new FindIdResponse();
                result.Activity = _mapper.Map<ModelActivity>(entity);

                return result;
            }
        }
    }
}
