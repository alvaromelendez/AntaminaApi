using Antamina.ApiHost.Common;
using Antamina.ApiHost.Entities.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Antamina.ApiHost.Proxy
{
    public class ServiceClient
    {
        private readonly ApiCredential _credential;
        private readonly UrlApis _urlApis;
        public ServiceClient(IOptions<ApiCredential> credential, IOptions<UrlApis> urlApis)
        {
            _credential = credential.Value;
            _urlApis = urlApis.Value;
        }
        public async Task<GetNotificationAllResponse> GetNotificationAll()
        {
            GetNotificationAllResponse response = null;
            try
            {
                var authenticationString = $"{_credential.UserName}:{_credential.UserPassword}";
                var base64String = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, _urlApis.GetNotificationAll);
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64String);

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.Converters.Add(new Extension.DateTimeConverter());

                    var httpResponse = await httpClient.SendAsync(requestMessage);
                    httpResponse.EnsureSuccessStatusCode();
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    response = JsonSerializer.Deserialize<GetNotificationAllResponse>(content, options);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
        public async Task<GetNotificationByIDResponse> GetNotificationByID()
        {
            GetNotificationByIDResponse response = null;
            try
            {
                var authenticationString = $"{_credential.UserName}:{_credential.UserPassword}";
                var base64String = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, _urlApis.GetNotificationByID);
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64String);

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.Converters.Add(new Extension.DateTimeConverter());

                    var httpResponse = await httpClient.SendAsync(requestMessage);
                    httpResponse.EnsureSuccessStatusCode();
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    response = JsonSerializer.Deserialize<GetNotificationByIDResponse>(content, options);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
        public async Task<string> CreateNotification(string request)
        {
            string response = string.Empty;
            try
            {
                var authenticationString = $"{_credential.UserName}:{_credential.UserPassword}";
                var base64String = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(_urlApis.CreateNotification);
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {base64String}");

                    var httpResponse = await httpClient.PostAsync(_urlApis.CreateNotification, new StringContent(request, Encoding.UTF8, "application/json"));
                    response = await httpResponse.Content.ReadAsStringAsync();
                    httpResponse.EnsureSuccessStatusCode();
                }
            }
            catch (Exception)
            {

                throw new Exception($"Message: {response}");
            }
            return response;
        }
    }
}
