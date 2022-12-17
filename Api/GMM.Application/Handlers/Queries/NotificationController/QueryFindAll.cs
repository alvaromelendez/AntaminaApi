using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.NotificationController
{
    public class QueryFindAll : IRequest<ModelNotification>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, ModelNotification>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IApiServiceProgrammed _apiServiceProgrammed;
            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper, IApiServiceProgrammed apiServiceProgrammed)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._apiServiceProgrammed = apiServiceProgrammed;
            }

            public async Task<ModelNotification> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelNotification>("sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotification/?sap-client=110");
                var result = _mapper.Map<ModelNotification>(response.Result);
                return result;
            }
        }
    }
}
