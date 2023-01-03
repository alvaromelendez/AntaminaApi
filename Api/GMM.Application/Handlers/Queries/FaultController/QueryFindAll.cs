using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.FaultController;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.FaultController
{
    public class QueryFindAll : IRequest<ModelFault>
    {
        public FindAllRequest Request { get; }
        public QueryFindAll(FindAllRequest request)
        {
            Request = request;
        }    
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, ModelFault>
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
            public async Task<ModelFault> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelFault>($"/sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotification('{request.Request.MaintenanceNotification}')/to_Item/?sap-client=110");
                var result = _mapper.Map<ModelFault>(response.Result);
                return result;
            }
        }
    }
}
