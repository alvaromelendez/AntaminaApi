using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.NotificationController;
using GMM.Application.Response.NotificationController;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.NotificationController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public FindIdRequest Request { get; }
        public QueryFindId(FindIdRequest request)
        {
            Request = request;
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
                var response = await _apiServiceProgrammed.GetAsync<ModelNotificationDetail>($"sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotification('{request.Request.MaintenanceNotification}')/?sap-client=110");
                FindIdResponse result = new FindIdResponse();
                result.Notification = _mapper.Map<ModelNotificationDetail>(response.Result);
                return result;
            }
        }
    }
}
