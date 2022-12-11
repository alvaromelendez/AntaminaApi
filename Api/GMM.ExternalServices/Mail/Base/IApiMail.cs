using GMM.ExternalServices.Mail.Models;

namespace GMM.ExternalServices.Mail.Base
{
    public interface IApiMail
    {
        Task<MailNotificationResponse> SendEmail(MailRequest mailRequest, string token);
    }
}
