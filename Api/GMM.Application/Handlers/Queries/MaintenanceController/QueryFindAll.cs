using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.MaintenanceController
{
    public class QueryFindAll : IRequest<ModelMaintenanceFindAll>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, ModelMaintenanceFindAll>
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
            public async Task<ModelMaintenanceFindAll> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelMaintenanceFindAll>("sap/opu/odata/sap/API_MAINTENANCEORDER/MaintenanceOrder?$filter=MainWorkCenter eq 'MECAMIO'&sap-client=110");
                var result = _mapper.Map<ModelMaintenanceFindAll>(response.Result);
                return result;
            }
        }
    }
}
