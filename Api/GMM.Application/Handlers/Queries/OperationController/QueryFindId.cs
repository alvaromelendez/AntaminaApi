using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.OperationController;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.OperationController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdOperation { get; }
        public QueryFindId(Guid idOperation)
        {
            IdOperation = idOperation;
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
                var response = await _apiServiceProgrammed.GetAsync<ModelOperationFindId>($"sap/opu/odata/sap/API_MAINTENANCEORDER/MaintenanceOrderOperation(MaintenanceOrder='10000133',MaintenanceOrderOperation='0010',MaintenanceOrderSubOperation='')/to_MaintOrderOpComponent/?sap-client=110");
                FindIdResponse result = new FindIdResponse();
                result.Operation = _mapper.Map<ModelOperationFindId>(response.Result);
                return result;
            }
        }
    }
}
