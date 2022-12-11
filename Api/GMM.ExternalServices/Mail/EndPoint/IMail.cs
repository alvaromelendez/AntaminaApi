using GMM.ExternalServices.Mail.Models;

namespace GMM.ExternalServices.Mail.EndPoint
{
    public interface IMail
    {
        Task<MailNotificationResponse> SendEmail(MailRequest mailRequest, string token);
    }
}
