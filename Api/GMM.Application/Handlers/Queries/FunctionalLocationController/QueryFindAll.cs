using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.FunctionalLocationController
{
    public class QueryFindAll : IRequest<FunctionalLocation>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, FunctionalLocation>
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
            public async Task<FunctionalLocation> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                //var response = await _apiServiceProgrammed.GetAsync<FunctionalLocation>("sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotificationItem(MaintenanceNotification='10000381',MaintenanceNotificationItem='1')/to_ItemCause/?sap-client=110");
                //var result = _mapper.Map<FunctionalLocation>(response.Result);
                //var result = _mapper.Map<FunctionalLocation>(new List<FunctionalLocation>() { new FunctionalLocation() { Key = 1, Descritption = "A-01-01-04-A18-HT0060" } });

                var response = await _apiServiceProgrammed.GetAsync<FunctionalLocation>("");
                response.Result = new FunctionalLocation() { Key = 1, Descritption = "A-01-01-04-A18-HT0060" };
                var result = _mapper.Map<FunctionalLocation>(response.Result);

                return result;
            }
        }
    }
}
