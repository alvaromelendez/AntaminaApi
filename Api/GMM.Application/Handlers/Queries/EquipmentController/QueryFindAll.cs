using Amazon.S3.Model;
using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.EquipmentController
{
    public class QueryFindAll : IRequest<Equipment>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, Equipment>
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
            public async Task<Equipment> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                //var response = await _apiServiceProgrammed.GetAsync<Equipment>("sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotificationItem(MaintenanceNotification='10000381',MaintenanceNotificationItem='1')/to_ItemCause/?sap-client=110");
                //var result = _mapper.Map<Equipment>(response.Result);
                var response = await _apiServiceProgrammed.GetAsync<Equipment>("");
                response.Result = new Equipment() { Key = 1, Descritption = "HTENG" };
                var result = _mapper.Map<Equipment>(response.Result);
                return result;
            }
        }
    }
}
