using System.Text;

namespace GMM.Web.Common
{
    public class ServiceClient : IServiceClient
    {
        public async Task<string> Send<TRequest>(HttpMethod httpMethod, string endpoint, TRequest request)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
            {
                Method = httpMethod,
                RequestUri = new Uri($"http://localhost:10100/{endpoint}"),
                Content = new StringContent(
                                    System.Text.Json.JsonSerializer.Serialize(request),
                                    Encoding.UTF8,
                                    "application/json")
            };
            var response = await httpClient.SendAsync(httpRequestMessage);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
            else
            {
                throw new Exception(response.ToString());
            }
        }

        public async Task<TResponse> Send<TResponse>(HttpMethod httpMethod, string endpoint, Dictionary<string, string> parameters)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, $"http://localhost:10100/{endpoint}");
            httpRequestMessage.Content = new FormUrlEncodedContent(parameters);

            var response = await httpClient.SendAsync(httpRequestMessage);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return System.Text.Json.JsonSerializer.Deserialize<TResponse>(responseString);
            }
            else
            {
                throw new Exception(response.ToString());
            }
        }
    }

    public interface IServiceClient
    {
        Task<string> Send<TRequest>(HttpMethod httpMethod, string endpoint, TRequest request);
        Task<TResponse> Send<TResponse>(HttpMethod httpMethod, string endpoint, Dictionary<string, string> parameters);
    }
}
