using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.FaultController;
using GMM.ExternalServices.ServiceProgrammed.Base;
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
            private readonly IApiServiceProgrammed _apiServiceProgrammed;
            public QueryFindIdHandler(IUnitOfWork unitOfWork, IMapper mapper, IApiServiceProgrammed apiServiceProgrammed)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._apiServiceProgrammed = apiServiceProgrammed;
            }
            public async Task<FindIdResponse> Handle(QueryFindId request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelFaultDetail>($"sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotification('10000381')/to_Item/?sap-client=110");
                FindIdResponse result = new FindIdResponse();
                result.Fault = _mapper.Map<ModelFaultDetail>(response.Result);
                return result;
            }
        }
    }
}
