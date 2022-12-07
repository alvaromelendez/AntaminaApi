using Antamina.ApiHost.Common;
using Antamina.ApiHost.Entities.DTO;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
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
        public async Task<GetNotificationResponse> Get()
        {
            GetNotificationResponse response = null;
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
                    response = JsonSerializer.Deserialize<GetNotificationResponse>(content, options);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
