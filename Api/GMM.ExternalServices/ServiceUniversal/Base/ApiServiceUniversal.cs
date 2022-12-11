using GMM.ExternalServices.ServiceUniversal.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace GMM.ExternalServices.ServiceUniversal.Base
{
    public class ApiServiceUniversal : IApiServiceUniversal
    {
        private readonly ServiceUniversalOptions _serviceUniversalOptions;
        public ApiServiceUniversal(ServiceUniversalOptions serviceUniversalOptions)
        {
            this._serviceUniversalOptions = serviceUniversalOptions;
        }
        public async Task<IEnumerable<UniversalEmployeeResponse>> ListEmployee(UniversalEmployeeRequest parameter)
        {
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(
                    $"{_serviceUniversalOptions.UriListEmployee}userId:{parameter.UserId},permission:{parameter.Permission},filter:{parameter.Filter ?? ""},location:{parameter.Location}"))
                {
                    var resultJson = await response.Result.Content.ReadAsStringAsync();
                    if (resultJson == "[]") return Array.Empty<UniversalEmployeeResponse>();
                    var permissionResponse = JsonConvert.DeserializeObject<IEnumerable<UniversalEmployeeResponse>>(resultJson);
                    return permissionResponse;
                }
            }
        }
        public async Task<IEnumerable<UniversalCompanyResponse>> ListCompany(UniversalCompanyRequest parameter)
        {
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(
                    $"{_serviceUniversalOptions.UriListCompany}state:{parameter.State}"))
                {
                    var resultJson = await response.Result.Content.ReadAsStringAsync();
                    if (resultJson == "[]") return Array.Empty<UniversalCompanyResponse>();
                    var permissionResponse = JsonConvert.DeserializeObject<IEnumerable<UniversalCompanyResponse>>(resultJson);
                    return permissionResponse;
                }
            }
        }
        public async Task<IEnumerable<UniversalPositionResponse>> ListPosition(UniversalPositionRequest parameter)
            {
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(
                    $"{_serviceUniversalOptions.UriListPosition}"))
                {
                    var resultJson = await response.Result.Content.ReadAsStringAsync();
                    if (resultJson == "[]") return Array.Empty<UniversalPositionResponse>();
                    var permissionResponse = JsonConvert.DeserializeObject<IEnumerable<UniversalPositionResponse>>(resultJson);
                    return permissionResponse;
                }
            }
        }
        public async Task<IEnumerable<UniversalManagementResponse>> ListManagement(UniversalManagementRequest parameter)
        {
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(
                    $"{_serviceUniversalOptions.UriListManagement}"))
                {
                    var resultJson = await response.Result.Content.ReadAsStringAsync();
                    if (resultJson == "[]") return Array.Empty<UniversalManagementResponse>();
                    var permissionResponse = JsonConvert.DeserializeObject<IEnumerable<UniversalManagementResponse>>(resultJson);
                    return permissionResponse;
                }
            }
        }
    }
}
