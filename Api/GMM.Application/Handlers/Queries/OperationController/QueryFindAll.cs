using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.OperationController
{
    public class QueryFindAll : IRequest<ModelOperationFindAll>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, ModelOperationFindAll>
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
            public async Task<ModelOperationFindAll> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelOperationFindAll>("/sap/opu/odata/sap/API_MAINTENANCEORDER/MaintenanceOrder('10000133')/to_MaintenanceOrderOperation/?sap-client=110");
                var result = _mapper.Map<ModelOperationFindAll>(response.Result);
                return result;
            }
        }
    }
}
