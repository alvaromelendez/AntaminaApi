using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;

namespace GMM.ExternalServices.ServiceProgrammed.Base
{
    public class ApiServiceProgrammed : IApiServiceProgrammed
    {

        private readonly HttpClient _httpClient;
        private readonly ServiceProgrammedOptions _serviceProgrammed;
        /// <summary>
        /// Inicializa una sola vez el HttpClient.
        /// </summary>
        /// <param name="httpClient"></param>
        public ApiServiceProgrammed(HttpClient httpClient, ServiceProgrammedOptions serviceProgrammed)
        {
            this._httpClient = httpClient;
            _serviceProgrammed = serviceProgrammed;
        }
        public async Task<ApiGenericResponse<TypeObject>> GetAsync<TypeObject>(string endpoint) where TypeObject : class
        {
            ApiGenericResponse<TypeObject> apiResponse = new ApiGenericResponse<TypeObject>();

            using HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("GET"), $"{_serviceProgrammed.Uri}{endpoint}");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{_serviceProgrammed.UserName}:{_serviceProgrammed.UserPassword}")));

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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
        public async Task<ApiGenericResponse<TypeObject>> PostAsync<TypeObject>(string code, string header, string endpoint, string data) where TypeObject : class
        {
            ApiGenericResponse<TypeObject> apiResponse = new ApiGenericResponse<TypeObject>();

            using var content = new StringContent(data, Encoding.UTF8, "application/xml");
            using HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("POST"), $"{_serviceProgrammed.Uri}{endpoint}") { Content = content };
            request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{_serviceProgrammed.UserName}:{_serviceProgrammed.UserPassword}"))}");
            request.Headers.Add("X-CSRF-Token", code);
            request.Headers.Add("Cookie", header);

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using HttpResponseMessage response = await _httpClient.SendAsync(request);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                apiResponse.IsSuccess = true;
                apiResponse.Result = JsonConvert.DeserializeObject<TypeObject>(jsonResponse);
                apiResponse.Message = "Se creó el registro correctamente.";
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                apiResponse.IsSuccess = false;
                apiResponse.Message = "No autorizado";
            }
            else
            {
                apiResponse.IsSuccess = false;
                apiResponse.Message = jsonResponse;
            }               

            return apiResponse;

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