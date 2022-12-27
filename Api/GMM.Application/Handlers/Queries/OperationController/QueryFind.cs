using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.OperationController
{
    public class QueryFind : IRequest<ModelOperationFind>
    {
        public class QueryFindHandler : IRequestHandler<QueryFind, ModelOperationFind>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IApiServiceProgrammed _apiServiceProgrammed;
            public QueryFindHandler(IUnitOfWork unitOfWork, IMapper mapper, IApiServiceProgrammed apiServiceProgrammed)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._apiServiceProgrammed = apiServiceProgrammed;
            }
            public async Task<ModelOperationFind> Handle(QueryFind request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelOperationFind>("sap/opu/odata/sap/API_MAINTENANCEORDER/MaintenanceOrderOperation(MaintenanceOrder='4000087',MaintenanceOrderOperation='0010',MaintenanceOrderSubOperation='')/?sap-client=110");
                var result = _mapper.Map<ModelOperationFind>(response.Result);
                return result;
            }
        }
    }
}
