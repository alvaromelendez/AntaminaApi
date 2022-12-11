using GMM.ExternalServices.ServiceProgrammed.EndPoint;
using GMM.ExternalServices.ServiceUniversal.EndPoint;
using GMM.ExternalServices.ServiceUniversal.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.ServiceUniversalController
{
    public class QueryListEmployee : IRequest<IEnumerable<UniversalEmployeeResponse>>
    {
        public string Code { get; }
        public string Header { get; }

        public QueryListEmployee(string code, string header)
        {
            Code = code;
            Header = header;
        }

        public class QueryListEmployeeHandler : IRequestHandler<QueryListEmployee, IEnumerable<UniversalEmployeeResponse>>
        {
            private readonly IServiceUniversal _serviceUniversal;
            private readonly IAuthentication _authentication;
            public QueryListEmployeeHandler(IServiceUniversal serviceUniversal,
                IAuthentication authentication)
            {
                _serviceUniversal = serviceUniversal;
                this._authentication = authentication;
            }

            public async Task<IEnumerable<UniversalEmployeeResponse>> Handle(QueryListEmployee request, CancellationToken cancellationToken)
            {
                var _header_response = await this._authentication.GetDeserializeObject(
                            new ExternalServices.ServiceProgrammed.Models.EncryptRequest { Code = request.Code, TextTransform = request.Header });
                var _base = this._authentication.GetObjectTransform(_header_response.Result.Value);

                var _request = new UniversalEmployeeRequest()
                {
                    UserId = _base.EmployeeId,
                    Permission = "ALL;EDITTIMEEVENT;CHILD;ME;",//_base.ProcessAllow
                    Location = String.Empty,
                    Filter = null
                };

                var r = await _serviceUniversal.ListEmployee(_request);
                return r;
            }
        }
    }
}
