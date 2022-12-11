using GMM.ExternalServices.ServiceUniversal.Base;
using GMM.ExternalServices.ServiceUniversal.Models;

namespace GMM.ExternalServices.ServiceUniversal.EndPoint
{
    public class ServiceUniversal : IServiceUniversal
    {
        private readonly IApiServiceUniversal _apiServiceUniversal;
        public ServiceUniversal(IApiServiceUniversal apiServiceUniversal)
        {
            this._apiServiceUniversal = apiServiceUniversal;
        }
        public Task<IEnumerable<UniversalEmployeeResponse>> ListEmployee(UniversalEmployeeRequest parameter)
        {
            return _apiServiceUniversal.ListEmployee(parameter);
        }
        public Task<IEnumerable<UniversalCompanyResponse>> ListCompany(UniversalCompanyRequest parameter)
        {
            return _apiServiceUniversal.ListCompany(parameter);
        }
        public Task<IEnumerable<UniversalPositionResponse>> ListPosition(UniversalPositionRequest parameter)
        {
            return _apiServiceUniversal.ListPosition(parameter);
        }
        public Task<IEnumerable<UniversalManagementResponse>> ListManagement(UniversalManagementRequest parameter)
        {
            return _apiServiceUniversal.ListManagement(parameter);
        }
    }
}
