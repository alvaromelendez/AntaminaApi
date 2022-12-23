using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.MaintenanceController;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.MaintenanceController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdMaintenance { get; }
        public QueryFindId(Guid idMaintenance)
        {
            IdMaintenance = idMaintenance;
        }
        public class QueryFindIdHandler : IRequestHandler<QueryFindId, FindIdResponse>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IApiServiceProgrammed _apiServiceProgrammed;
            public QueryFindIdHandler(IUnitOfWork unitOfWork, IMapper mapper, IApiServiceProgrammed apiServiceProgrammed)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._apiServiceProgrammed = apiServiceProgrammed;
            }
            public async Task<FindIdResponse> Handle(QueryFindId request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelMaintenanceFindByID>($"sap/opu/odata/sap/API_MAINTENANCEORDER/MaintenanceOrder('10000133')/?sap-client=110");
                FindIdResponse result = new FindIdResponse();
                result.Maintenance = _mapper.Map<ModelMaintenanceFindByID>(response.Result);
                return result;
            }
        }
    }
}
