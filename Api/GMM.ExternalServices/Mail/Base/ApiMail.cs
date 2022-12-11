using GMM.ExternalServices.Mail.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace GMM.ExternalServices.Mail.Base
{
    public class ApiMail : IApiMail
    {
        private readonly MailOptions _mailOptions;
        public ApiMail(MailOptions mailOptions)
        {
            this._mailOptions = mailOptions;
        }
        public async Task<MailNotificationResponse> SendEmail(MailRequest mailRequest, string token)
        {
            using (var client = new HttpClient(new HttpClientHandler()))
            {
                var index = 0;
                client.BaseAddress = new Uri(_mailOptions.ServiceEmailQueue);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);

                using (var formData = new MultipartFormDataContent())
                {
                    formData.Add(new StringContent(mailRequest.AppOrigin), "AppOrigen");
                    formData.Add(new StringContent(mailRequest.MailFrom), "CorreoFrom");
                    formData.Add(new StringContent(mailRequest.MailFromAlias ?? ""), "CorreoFromAlias");
                    formData.Add(new StringContent(mailRequest.MailSubject), "CorreoSubject");
                    formData.Add(new StringContent(mailRequest.MailTo), "CorreoTo");
                    formData.Add(new StringContent(mailRequest.MailCc ?? ""), "CorreoCc");
                    formData.Add(new StringContent(mailRequest.MailBcc ?? ""), "CorreoBcc");
                    formData.Add(new StringContent(mailRequest.MailBodyHtml ?? ""), "CorreoBodyHtml");
                    formData.Add(new StringContent(mailRequest.MailBodyImg ?? ""), "CorreoBodyImg");

                    foreach (var file in mailRequest.FileAttached ?? Enumerable.Empty<KeyValuePair<string, byte[]>>())
                        formData.Add(new ByteArrayContent(file.Value), $"file{ index++ }", file.Key);

                    //var response = client.PostAsync("", formData).Result;
                    //var readResponse = response.Content.ReadAsStringAsync().Result;
                    //var mailNotificationResponse = JsonConvert.DeserializeObject<MailNotificationResponse>(readResponse);

                    using HttpResponseMessage response = await client.PostAsync("", formData);
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var mailNotificationResponse = JsonConvert.DeserializeObject<MailNotificationResponse>(jsonResponse);

                    return mailNotificationResponse;
                }
            }
        }

    }
}
