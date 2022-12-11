using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.ActivityController
{
    public class QueryFindAll : IRequest<List<ModelActivity>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<ModelActivity>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }


            public async Task<List<ModelActivity>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                //var listEntity = await _unitOfWork.Activitys.AsNoTracking().ToListAsync(cancellationToken);
                //if (listEntity == null || listEntity.Count == 0)
                //    throw new ReecException(ReecEnums.Category.PartialContent, ConstantMessage.NotRecords);
                var listEntity = new List<ModelActivity>() {
                  new ModelActivity(){ IdActivity = Guid.NewGuid(),
                  MaintNotificationActivity= 1,
                  MaintenanceNotification= 10000381,
                  MaintenanceNotificationItem= 1,
                  MaintNotifActivitySortNumber= 6,
                  MaintNotifActyTxt= "TEST Actividades a realizar",
                  MaintNotifActivityCodeGroup= "PM1",
                  NotifActivityCodeGroupText= "Actividades de mantenimiento",
                  MaintNotificationActivityCode= 1,
                  NotifActivityCodeText= "Actividad 1",
                  PlannedStartDate= Convert.ToDateTime("2022-10-02T00:00:00"),
                  PlannedStartTime= "PT07H00M00S",
                  PlannedEndDate= "",
                  PlannedEndTime= "PT00H00M00S",
                  IsDeleted= false
                },
                new ModelActivity(){ IdActivity = Guid.NewGuid(),
                  MaintNotificationActivity= 1,
                  MaintenanceNotification= 10000382,
                  MaintenanceNotificationItem= 1,
                  MaintNotifActivitySortNumber= 6,
                  MaintNotifActyTxt= "TEST Actividades a realizar",
                  MaintNotifActivityCodeGroup= "PM1",
                  NotifActivityCodeGroupText= "Actividades de mantenimiento",
                  MaintNotificationActivityCode= 1,
                  NotifActivityCodeText= "Actividad 2",
                  PlannedStartDate= Convert.ToDateTime("2022-10-02T00:00:00"),
                  PlannedStartTime= "PT07H00M00S",
                  PlannedEndDate= "",
                  PlannedEndTime= "PT00H00M00S",
                  IsDeleted= false
                }};
                var result = _mapper.Map<List<ModelActivity>>(listEntity);
                return result;
            }
        }
    }
}
