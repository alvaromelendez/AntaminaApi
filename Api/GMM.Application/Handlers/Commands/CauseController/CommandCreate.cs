using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.CauseController;
using GMM.Common.Helpers;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;
using Reec.Inspection;
using System.Xml.Linq;

namespace GMM.Application.Handlers.Commands.CauseController
{
    public class CommandCreate : IRequest<ReecMessage>
    {
        public CreateCauseRequest Model { get; }
        public string Code { get; set; }
        public string Header { get; set; }
        public CommandCreate(CreateCauseRequest createRequest, string code, string header)
        {
            Model = createRequest;
            Code = code;
            Header = header;
        }

        public class CommandCreateHandler : IRequestHandler<CommandCreate, ReecMessage>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IApiServiceProgrammed _apiServiceProgrammed;

            public CommandCreateHandler(IUnitOfWork unitOfWork, IMapper mapper, IApiServiceProgrammed apiServiceProgrammed)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._apiServiceProgrammed = apiServiceProgrammed;
            }
            public async Task<ReecMessage> Handle(CommandCreate request, CancellationToken cancellationToken)
            {
                string data = ConvertCreateCauseRequestToXML(request.Model);
                await _apiServiceProgrammed.PostAsync<ModelCauseCreate>
                    (request.Code,
                    request.Header,
                    "sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotificationItem(MaintenanceNotification='10000383',MaintenanceNotificationItem='1')/to_ItemCause/?sap-client=110",
                    data);
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.CreateMessage);
                return message;
            }

            private string ConvertCreateCauseRequestToXML(CreateCauseRequest request)
            {
                XNamespace aw = "http://www.w3.org/2005/Atom";
                XNamespace fc = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata";
                XNamespace fd = "http://schemas.microsoft.com/ado/2007/08/dataservices";
                XElement root = new XElement(aw + "entry",
                    new XAttribute("xmlns", "http://www.w3.org/2005/Atom"),
                    new XAttribute(XNamespace.Xmlns + "m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata"),
                    new XAttribute(XNamespace.Xmlns + "d", "http://schemas.microsoft.com/ado/2007/08/dataservices"),
                    new XElement(aw + "content",
                        new XAttribute("type", "application/xml"),
                        new XElement(fc + "properties",
                        new XElement(fd + "MaintenanceNotification", request.MaintenanceNotification),
                        new XElement(fd + "MaintenanceNotificationItem", request.MaintenanceNotificationItem),
                        new XElement(fd + "MaintenanceNotificationCause", request.MaintenanceNotificationCause),
                        new XElement(fd + "MaintNotifCauseText", request.MaintNotifCauseText),
                        new XElement(fd + "MaintNotifCauseCodeGroup", request.MaintNotifCauseCodeGroup),
                        new XElement(fd + "MaintNotifCauseCodeGroupName", request.MaintNotifCauseCodeGroupName),
                        new XElement(fd + "MaintNotificationCauseCode", request.MaintNotificationCauseCode),
                        new XElement(fd + "MaintNotificationCauseCodeName", request.MaintNotificationCauseCodeName),
                        new XElement(fd + "MaintNotificationRootCause", request.MaintNotificationRootCause),
                        new XElement(fd + "MaintNotificationRootCauseText", request.MaintNotificationRootCauseText),
                        new XElement(fd + "IsDeleted", request.IsDeleted)
                        )
                    )
                );
                return root.ToString();
            }
        }
    }
}
