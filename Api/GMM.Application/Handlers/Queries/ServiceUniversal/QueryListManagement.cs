using GMM.ExternalServices.ServiceUniversal.EndPoint;
using GMM.ExternalServices.ServiceUniversal.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.ServiceUniversalController
{
    public class QueryListManagement : IRequest<IEnumerable<UniversalManagementResponse>>
    {
        public UniversalManagementRequest Request { get; }

        public QueryListManagement(UniversalManagementRequest request)
        {
            this.Request = request;
        }

        public class QueryListManagementHandler : IRequestHandler<QueryListManagement, IEnumerable<UniversalManagementResponse>>
        {
            private readonly IServiceUniversal _serviceUniversal;
            public QueryListManagementHandler(IServiceUniversal serviceUniversal)
            {
                _serviceUniversal = serviceUniversal;
            }

            public async Task<IEnumerable<UniversalManagementResponse>> Handle(QueryListManagement request, CancellationToken cancellationToken)
            {
                var r = await _serviceUniversal.ListManagement(request.Request);
                return r;
            }
        }
    }
}
