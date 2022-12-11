using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.FaultController
{
    public class QueryFindAll : IRequest<List<ModelFault>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<ModelFault>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }


            public async Task<List<ModelFault>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                //var listEntity = await _unitOfWork.Faults.AsNoTracking().ToListAsync(cancellationToken);
                //if (listEntity == null || listEntity.Count == 0)
                //    throw new ReecException(ReecEnums.Category.PartialContent, ConstantMessage.NotRecords);
                var listEntity = new List<ModelFault>() {
                  new ModelFault(){
                   IdFault = Guid.NewGuid(),
                    MaintenanceNotification=10000383,
                    MaintenanceNotificationItem= 1,
                    MaintNotifItemText= "AVERIA TEST POSTMAN",
                    MaintNotifDamageCodeGroup= "CLM-01",
                    MaintNotifDamageCodeGroupName= "Textos explicacitivos para reclamación",
                    MaintNotificationDamageCode= 10,
                    MaintNotifDamageCodeName= "Texto explicativo p.causa",
                    MaintNotifObjPrtCodeGroup= "PM1",
                    MaintNotifObjPrtCodeGroupName= "Mantenimiento de parte de objeto",
                    MaintNotifObjPrtCode= 1,
                    MaintNotifObjPrtCodeName= "Parte objeto 1",
                    IsDeleted= false
                  },
                  new ModelFault(){
                   MaintenanceNotification=10000384,
                    MaintenanceNotificationItem= 2,
                    MaintNotifItemText= "AVERIA TEST POSTMAN 2",
                    MaintNotifDamageCodeGroup= "CLM-01",
                    MaintNotifDamageCodeGroupName= "Textos explicacitivos para reclamación",
                    MaintNotificationDamageCode= 10,
                    MaintNotifDamageCodeName= "Texto explicativo p.causa",
                    MaintNotifObjPrtCodeGroup= "PM1",
                    MaintNotifObjPrtCodeGroupName= "Mantenimiento de parte de objeto",
                    MaintNotifObjPrtCode= 1,
                    MaintNotifObjPrtCodeName= "Parte objeto 2",
                    IsDeleted= true
                  }
                };

                var result = _mapper.Map<List<ModelFault>>(listEntity);
                return result;
            }
        }
    }
}
