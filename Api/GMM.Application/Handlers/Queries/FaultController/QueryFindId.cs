using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.FaultController;
using MediatR;

namespace GMM.Application.Handlers.Queries.FaultController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdFault { get; }
        public QueryFindId(Guid idFault)
        {
            IdFault = idFault;
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
                //var entity = await _unitOfWork.Faults.AsNoTracking()
                //                .FirstOrDefaultAsync(x => x.IdFault == request.IdFault);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);
                var entity = new ModelFault()
                {
                    IdFault = request.IdFault,
                    MaintenanceNotification = 10000383,
                    MaintenanceNotificationItem = 1,
                    MaintNotifItemText = "AVERIA TEST POSTMAN",
                    MaintNotifDamageCodeGroup = "CLM-01",
                    MaintNotifDamageCodeGroupName = "Textos explicacitivos para reclamación",
                    MaintNotificationDamageCode = 10,
                    MaintNotifDamageCodeName = "Texto explicativo p.causa",
                    MaintNotifObjPrtCodeGroup = "PM1",
                    MaintNotifObjPrtCodeGroupName = "Mantenimiento de parte de objeto",
                    MaintNotifObjPrtCode = 1,
                    MaintNotifObjPrtCodeName = "Parte objeto 1",
                    IsDeleted = false
                };

                FindIdResponse result = new FindIdResponse();
                result.Fault = _mapper.Map<ModelFault>(entity);

                return result;
            }
        }
    }
}
