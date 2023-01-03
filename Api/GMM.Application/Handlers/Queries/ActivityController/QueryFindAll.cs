using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.ActivityController;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.ActivityController
{
    public class QueryFindAll : IRequest<ModelActivity>
    {
        public FindAllRequest Request { get; }
        public QueryFindAll(FindAllRequest request)
        {
            Request = request;
        }
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, ModelActivity>
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
            public async Task<ModelActivity> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<ModelActivity>($"sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotificationItem(MaintenanceNotification='{request.Request.MaintenanceNotification}',MaintenanceNotificationItem='1')/to_ItemActivity/?sap-client=110"); 
                var result = _mapper.Map<ModelActivity>(response.Result);
                return result;
            }
        }
    }
}
