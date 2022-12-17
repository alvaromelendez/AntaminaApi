using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.ActivityController;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.ActivityController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdActivity { get; }
        public QueryFindId(Guid idActivity)
        {
            IdActivity = idActivity;
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
                var response = await _apiServiceProgrammed.GetAsync<ModelActivity>($"sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotificationItem(MaintenanceNotification='10000381',MaintenanceNotificationItem='1')/to_ItemActivity/?sap-client=110");
                FindIdResponse result = new FindIdResponse();
                result.Activity = _mapper.Map<ModelActivity>(response.Result);
                return result;
            }
        }
    }
}
