using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.AwsS3.Models;
using GMM.ExternalServices.Mail.EndPoint;
using GMM.ExternalServices.Mail.Models;
using GMM.ExternalServices.ServiceProgrammed.EndPoint;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace GMM.Application.Handlers.Queries.Mail
{
    public class QuerySendMail : IRequest<MailNotificationResponse>
    {

        public MailRequest MailRequest { get; }
        public string Header { get; }
        public string Code { get; }

        public QuerySendMail(MailRequest mailRequest, string header,string code)
        {
            MailRequest = mailRequest;
            Header = header;
            Code = code;

        }

        public class QuerySendMailHandler : IRequestHandler<QuerySendMail, MailNotificationResponse>
        {
            private readonly IMail _mail;
            private readonly IUnitOfWork _unitOfWork;
            private readonly IAuthentication _authentication;

            public QuerySendMailHandler(IUnitOfWork unitOfWork, IMail mail, IAuthentication authentication)
            {
                this._unitOfWork = unitOfWork;
                this._mail = mail;
                this._authentication= authentication; 
            }

            public async Task<MailNotificationResponse> Handle(QuerySendMail request, CancellationToken cancellationToken)
            {
                //var masterTableRequest = GeneralQuery.ListMasterTable(new MasterTableRequest { IdMasterTable = AppSettingValue.MTEventConfigLimit });
                var sendMailRequest = new MailRequest();
                var masterTableRequest = await _unitOfWork.MasterTables.Queryable()
                               .Where(w =>
                                   (w.IdMasterTableParent == "02000")) 
                               .AsNoTracking()
                               .ToListAsync(cancellationToken);

                var emailTo = masterTableRequest.Where(x => x.Name?.ToLower()?.Trim() == "to").Select(x => x?.Value?.Trim()).FirstOrDefault();
                if (emailTo == "1")
                {
                    var emailAlias = masterTableRequest.Where(x => x.Name?.ToLower()?.Trim() == "alias").Select(x => x?.Value?.Trim()).FirstOrDefault();

                    var emailCc = masterTableRequest.Where(x => x.Name?.ToLower()?.Trim() == "cc").Select(x => x?.Value?.Trim())?.FirstOrDefault()?.Replace(",", ";")?.Split(';')?.Select(x => x?.Trim());
                    var emailBcc = masterTableRequest.Where(x => x.Name?.ToLower()?.Trim() == "bcc").Select(x => x?.Value?.Trim()).FirstOrDefault()?.Replace(",", ";")?.Split(';')?.Select(x => x?.Trim());
                    var emailSubject = masterTableRequest.Where(x => x.Name?.ToLower()?.Trim() == "subject").Select(x => x?.Value?.Trim()).FirstOrDefault();
                    var mailTo = masterTableRequest.Where(x => x.Name?.ToLower()?.Trim() == "mailto").Select(x => x?.Value?.Trim()).FirstOrDefault();
                    var emailBody = masterTableRequest.Where(x => x.Name?.ToLower()?.Trim() == "body").Select(x => x?.Value?.Trim()).FirstOrDefault();

                    //emailCc = clinicContact.Concat(emailCc);
                    //emailSubject = ReplaceWords(emailSubject, eventRequest, person);

                    //Se arma el body y reemplaza valores HTMl
                    var titulo = "";
                    var saludo = "";
                    var mensaje = "";
                    var despedida = "";

                    emailBody = ReplaceWords(emailBody, titulo, saludo, mensaje, despedida);

                    sendMailRequest = new MailRequest()
                    {
                        AppOrigin = "GMM",
                        MailFrom = request.MailRequest.MailFrom,
                        MailFromAlias = emailAlias,
                        MailSubject = emailSubject ?? "GMM",
                        MailTo = request.MailRequest.MailTo, //mailTo,
                        //MailTo = "richard.mamani@tivit.com",
                        MailCc = string.Join(";", emailCc),
                        //MailCc = "alan.gastelu@tivit.com",
                        //MailBcc = string.Join(";", emailBcc),
                        MailBodyHtml = emailBody
                    };
                }

                try
                {
                    //var tokenprueba = "eyJraWQiOiJWaHhxdnFRXC9vMkIxbHllemJ2dktnaElcL3NoY29JeVgrWWFNRzRVeWVIbkE9IiwiYWxnIjoiUlMyNTYifQ.eyJhdF9oYXNoIjoiWVVrbTdzME90NDA1MWk3NnVlQUlXZyIsInN1YiI6ImEyMjA4MTAxLWI1NDgtNDlhYS1iNjA0LTBiMjQ5ZWQ0MmM4YyIsImNvZ25pdG86Z3JvdXBzIjpbInVzLWVhc3QtMV9VSU9Td1lid2VfQXp1cmVBRCJdLCJlbWFpbF92ZXJpZmllZCI6ZmFsc2UsInByb2ZpbGUiOiI3MzI2ODQ0NSIsImlzcyI6Imh0dHBzOlwvXC9jb2duaXRvLWlkcC51cy1lYXN0LTEuYW1hem9uYXdzLmNvbVwvdXMtZWFzdC0xX1VJT1N3WWJ3ZSIsImNvZ25pdG86dXNlcm5hbWUiOiJhenVyZWFkX21hbnBvd2VyLmNzaWNjaGFAYW50YW1pbmEuY29tIiwiZ2l2ZW5fbmFtZSI6IkNhcmxvcyIsImxvY2FsZSI6ImRkMDFiMmE0LTNkYjktNDRkYy1iNTE5LTNkODE1NzQ5MGQ3MSIsIm1pZGRsZV9uYW1lIjoiTUFOUE9XRVI6IFNpY2NoYSwgQ2FybG9zIiwibm9uY2UiOiJaUUp0cG9tTFM2QWtqR1AtYXREYUhTMHZlMVcwX3JWMHFpZkRrWU14amotSG9qa09mNWgwbm42TjNabDduQTZWei1lNWZBRVcwVWRWeXVCbGRWd2s1b09lWm1rOUwzMXAtdkFPSTlhVW5GVHdGYVdDOTdVMlZvWFNacVdNRzFBMGJSVnVKTDZWd0JhSmFxSlNKUHNXbTQzbGhyOW1xLXBrS1gzYjBjeTM1NDgiLCJjb2duaXRvOnJvbGVzIjpbImFybjphd3M6aWFtOjo3MzA5MTM1MDc2NzY6cm9sZVwvQW50YW1pbmFTSUctYWxsYXBwLVVwbG9hZC1Sb2xlIl0sImF1ZCI6IjJuczhpOHNiYzFnanNzMmVzbGV2NWo3bG84IiwiaWRlbnRpdGllcyI6W3sidXNlcklkIjoibWFucG93ZXIuY3NpY2NoYUBhbnRhbWluYS5jb20iLCJwcm92aWRlck5hbWUiOiJBenVyZUFEIiwicHJvdmlkZXJUeXBlIjoiU0FNTCIsImlzc3VlciI6Imh0dHBzOlwvXC9zdHMud2luZG93cy5uZXRcLzgxZDYyMTc1LTFiNGUtNGUzZS1hYjA3LTkxNTVlYTkwNjNhYlwvIiwicHJpbWFyeSI6InRydWUiLCJkYXRlQ3JlYXRlZCI6IjE2MDMxMzIwODg5NjIifV0sInRva2VuX3VzZSI6ImlkIiwiYXV0aF90aW1lIjoxNjA3MzgwNzM5LCJuYW1lIjoibWFucG93ZXIuY3NpY2NoYUBhbnRhbWluYS5jb20iLCJleHAiOjE2MDczODQzMzksImlhdCI6MTYwNzM4MDczOSwiZmFtaWx5X25hbWUiOiJTaWNjaGEiLCJlbWFpbCI6Im1hbnBvd2VyLmNzaWNjaGFAYW50YW1pbmEuY29tIn0.gAR8PKVgqn0Ck4aa6jZ18nEkGfyzTKBRIKpO9OHvIb1TdAmUgbrJ98tsoFpgJeu8jjNqAx6LUk4ND2-PtaoapSuASzjQoLASh-ju6uotp5jRWmirY7A0hWFD9JR5k7dWpFjWP3qErIYU-4zueLmp5ygB0LJnHgzk_1r9wUjg0Wtqg-e3bYbt6ilq4VTOf-z5Msu5X4DiuU_-ZQns8M2GXmhDloqhD4yj6t9YNhxsqfueygUwlmwG4FTtPw5jPqjYcZ2h0SlVCtRfYk0KfqODvNpdVwGg6DPJAmFkH-CRTloyozEniOrDdUlifjbzZyOje8SEYl3rwPmUS7oPcSvCLA";
                    
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

            private string ReplaceWords(string str, string titulo, string saludo, string mensaje, string despedida)
            {
                var table = new StringBuilder("");

                table.Append("<tr>");
                table.Append("<td>"+ "Nombre template"+ "</td>");
                    table.Append("<td class='alert' >" + "Lower Limit" + "</td>");
                    table.Append("<td class='critico' >" +  "Upper Limit" + "</td>");

                    table.Append("<td>" +  "User Record Creation Date" + "</td>");
                    table.Append("<td>" +  "Item Record Creation Date" + "</td>");
                    table.Append("</tr>");

                    if (1 != 1)
                    {
                        table.Append("<tr>");
                        table.Append("<td></td>");
                        table.Append("<td class='alert' >" + "Low Limit 2" + "</td>");
                        table.Append("<td class='critico' >" + "Upper Limit" + "</td>");

                        table.Append("<td>" + "User Record Creation Date 2 " + " </td>");
                        table.Append("<td>" + "Item Record Creation Date 2" + "</td>");
                        table.Append("</tr>");
                    }

                str = table.ToString();

                return str;

            }
        
        }
    }
}
