using MediatR;
using GMM.ExternalServices.Mail.Models;
using GMM.ExternalServices.Mail.EndPoint;
using GMM.ExternalServices.ServiceProgrammed.EndPoint;
using Newtonsoft.Json;
using GMM.ExternalServices.AwsS3.Models;

namespace GMM.Application.Handlers.Commands.Mail
{
    public class CommandSendMail : IRequest<MailNotificationResponse>
    {
        public MailRequest Request { get; }
        public string Header { get; }
        public string Code { get; }
        public CommandSendMail(MailRequest request, string header, string code)
        {
            this.Request = request;
            this.Header = header;
            this.Code = code;
        }

        public class CommandCreateHandler : IRequestHandler<CommandSendMail, MailNotificationResponse>
        {
            private readonly IMail _mail;
            private readonly IAuthentication _authentication;

            public CommandCreateHandler(IMail mail, IAuthentication authentication)
            {
                this._mail = mail;
                this._authentication = authentication;
            }

            public async Task<MailNotificationResponse> Handle(CommandSendMail request, CancellationToken cancellationToken)
            {
                try
                {
                    var sendMailRequest = new MailRequest()
                    {
                        AppOrigin = "GMM",
                        MailFrom = "noreply@antamina.com",
                        MailFromAlias = request.Request.MailFromAlias ?? String.Empty,
                        MailSubject = request.Request.MailSubject ?? "GMM",
                        MailTo = request.Request.MailTo,
                        MailBodyHtml = request.Request.MailBodyHtml
                    };

                    var header_response = await this._authentication.GetDeserializeObject(
                            new ExternalServices.ServiceProgrammed.Models.EncryptRequest { Code = request.Code, TextTransform = request.Header });
                    var rf = JsonConvert.DeserializeObject<TokenAws>(header_response.Result.Value);

                    MailNotificationResponse result = new MailNotificationResponse();
                    result = await _mail.SendEmail(sendMailRequest, rf.Token);

                    return result;
                }
                catch (Exception ex)
                {
                    return null;

                    throw;
                }
            }
        }
    }
}
