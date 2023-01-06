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

namespace GMM.Application.Handlers.Queries.NotificationController
{
    public class QueryToken : IRequest<string>
    {
        public QueryToken()
        {
        }
        public class QueryTokenHandler : IRequestHandler<QueryToken, string>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IApiServiceProgrammed _apiServiceProgrammed;
            public QueryTokenHandler(IUnitOfWork unitOfWork, IMapper mapper, IApiServiceProgrammed apiServiceProgrammed)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._apiServiceProgrammed = apiServiceProgrammed;
            }

            public async Task<string> Handle(QueryToken request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetToken($"/sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotification('10000136')");
                return response;
            }
        }
    }
}
