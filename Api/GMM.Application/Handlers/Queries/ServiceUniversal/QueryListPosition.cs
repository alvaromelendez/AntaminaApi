using GMM.ExternalServices.ServiceUniversal.EndPoint;
using GMM.ExternalServices.ServiceUniversal.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.ServiceUniversalController
{
    public class QueryListPosition : IRequest<IEnumerable<UniversalPositionResponse>>
    {
        public UniversalPositionRequest Request { get; }

        public QueryListPosition(UniversalPositionRequest request)
        {
            this.Request = request;
        }

        public class QueryListPositionHandler : IRequestHandler<QueryListPosition, IEnumerable<UniversalPositionResponse>>
        {
            private readonly IServiceUniversal _serviceUniversal;
            public QueryListPositionHandler(IServiceUniversal serviceUniversal)
            {
                _serviceUniversal = serviceUniversal;
            }

            public async Task<IEnumerable<UniversalPositionResponse>> Handle(QueryListPosition request, CancellationToken cancellationToken)
            {
                var r = await _serviceUniversal.ListPosition(request.Request);
                return r;
            }
        }
    }
}
