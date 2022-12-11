using GMM.ExternalServices.Mail.Base;
using GMM.ExternalServices.Mail.Models;

namespace GMM.ExternalServices.Mail.EndPoint
{
    public class Mail : IMail
    {
        private readonly IApiMail _apiMail;

        public Mail(IApiMail apiMail)
        {
            this._apiMail = apiMail;
        }

        public Task<MailNotificationResponse> SendEmail(MailRequest mailRequest, string token)
        {
            return _apiMail.SendEmail(mailRequest, token);
        }
    }
}
