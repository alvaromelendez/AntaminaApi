using GMM.ExternalServices.ServiceUniversal.Models;

namespace GMM.ExternalServices.ServiceUniversal.Base
{
    public interface IApiServiceUniversal
    {
        Task<IEnumerable<UniversalEmployeeResponse>> ListEmployee(UniversalEmployeeRequest parameter);
        Task<IEnumerable<UniversalCompanyResponse>> ListCompany(UniversalCompanyRequest parameter);
        Task<IEnumerable<UniversalPositionResponse>> ListPosition(UniversalPositionRequest parameter);
        Task<IEnumerable<UniversalManagementResponse>> ListManagement(UniversalManagementRequest parameter);
    }
}
