using GMM.ExternalServices.ServiceUniversal.EndPoint;
using GMM.ExternalServices.ServiceUniversal.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.ServiceUniversalController
{
    public class QueryListCompany : IRequest<IEnumerable<UniversalCompanyResponse>>
    {
        public UniversalCompanyRequest Request { get; }

        public QueryListCompany(UniversalCompanyRequest request)
        {
            this.Request = request;
        }

        public class QueryListCompanyHandler : IRequestHandler<QueryListCompany, IEnumerable<UniversalCompanyResponse>>
        {
            private readonly IServiceUniversal _serviceUniversal;
            public QueryListCompanyHandler(IServiceUniversal serviceUniversal)
            {
                _serviceUniversal = serviceUniversal;
            }

            public async Task<IEnumerable<UniversalCompanyResponse>> Handle(QueryListCompany request, CancellationToken cancellationToken)
            {
                var r = await _serviceUniversal.ListCompany(request.Request);
                return r;
            }
        }
    }
}
