using Antamina.ApiHost.Common;
using Antamina.ApiHost.Entities.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

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

        public async Task<Root> GetActivity()
        {
            Root response = null;
            try
            {
                var authenticationString = $"{_credential.UserName}:{_credential.UserPassword}";
                var base64String = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, _urlApis.GetActivity);
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64String);

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.Converters.Add(new Extension.DateTimeConverter());

                    var httpResponse = await httpClient.SendAsync(requestMessage);
                    httpResponse.EnsureSuccessStatusCode();
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    var response2 = Extension.DeserializeResponseXML<D>(content);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
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
                    //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

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
        public async Task<GetNotificationByIDResponse> GetNotificationByID(string notificationID, long sap_Client_ID)
        {
            GetNotificationByIDResponse response = null;
            try
            {
                var authenticationString = $"{_credential.UserName}:{_credential.UserPassword}";
                var base64String = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));

                var requestMessage = new HttpRequestMessage(HttpMethod.Get, String.Format(_urlApis.GetNotificationByID, notificationID, sap_Client_ID));
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
        public async Task<CreateNotificationResponse> CreateNotification(string request, string xCSRF_Token, string cookie)
        {
            CreateNotificationResponse response = null;
            try
            {
                var authenticationString = $"{_credential.UserName}:{_credential.UserPassword}";
                var base64String = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(_urlApis.CreateNotification);
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {base64String}");
                    httpClient.DefaultRequestHeaders.Add("X-CSRF-Token", xCSRF_Token);
                    httpClient.DefaultRequestHeaders.Add("Cookie", cookie);

                    var httpResponse = await httpClient.PostAsync(_urlApis.CreateNotification, new StringContent(request, Encoding.UTF8, "application/xml"));
                    response = Extension.DeserializeResponseXML<CreateNotificationResponse>(await httpResponse.Content.ReadAsStringAsync());
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
