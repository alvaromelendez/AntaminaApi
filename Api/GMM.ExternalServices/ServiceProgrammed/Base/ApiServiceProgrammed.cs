using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
 
namespace GMM.ExternalServices.ServiceProgrammed.Base
{
    public class ApiServiceProgrammed : IApiServiceProgrammed
    {

        private readonly HttpClient _httpClient;

        /// <summary>
        /// Inicializa una sola vez el HttpClient.
        /// </summary>
        /// <param name="httpClient"></param>
        public ApiServiceProgrammed(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }


        
        public async Task<ApiGenericResponse<TypeObject>> GetAsync<TypeObject>(string code, string header, string url) where TypeObject : class
        {
            ApiGenericResponse<TypeObject> apiResponse = new ApiGenericResponse<TypeObject>();

            using HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("GET"), url);
            request.Headers.Add("Code", code);
            request.Headers.Add("Header", header);

            using HttpResponseMessage response = await _httpClient.SendAsync(request);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                apiResponse.IsSuccess = true;
                apiResponse.Result = JsonConvert.DeserializeObject<TypeObject>(jsonResponse);
            }
            else
                apiResponse.Message = response.ToString();

            return apiResponse;

        }

        public async Task<ApiGenericResponse<TypeObject>> PostAsync<TypeObject>(string code, string header, string url, object entity) where TypeObject : class
        {
            ApiGenericResponse<TypeObject> apiResponse = new ApiGenericResponse<TypeObject>();

            var json = JsonConvert.SerializeObject(entity);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("POST"), url) { Content = content };
            request.Headers.Add("Code", code);
            request.Headers.Add("Header", header);

            using HttpResponseMessage response = await _httpClient.SendAsync(request);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                apiResponse.IsSuccess = true;
                apiResponse.Result = JsonConvert.DeserializeObject<TypeObject>(jsonResponse);
            }
            else if(response.StatusCode == HttpStatusCode.Unauthorized) 
            {
                apiResponse.Message = "No autorizado";
            }
            else
                apiResponse.Message = response.ToString();

            return apiResponse;

        }


        public async Task<ApiGenericResponse<TypeObject>> PostAnonymousAsync<TypeObject>(string url, object entity) 
        {
            ApiGenericResponse<TypeObject> apiResponse = new ApiGenericResponse<TypeObject>();

            var json = JsonConvert.SerializeObject(entity);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");
            using HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("POST"), url) { Content = content };

            using HttpResponseMessage response = await _httpClient.SendAsync(request);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                apiResponse.IsSuccess = true;
                apiResponse.Result = JsonConvert.DeserializeObject<TypeObject>(jsonResponse);
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                apiResponse.Message = "No autorizado";
            }
            else
                apiResponse.Message = response.ToString();

            return apiResponse;

        }



    }

}