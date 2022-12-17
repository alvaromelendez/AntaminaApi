using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.ActivityController;
using GMM.Application.Request.NotificationController;
using GMM.Common.Helpers;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;
using Reec.Inspection;
using System.Xml.Linq;

namespace GMM.Application.Handlers.Commands.NotificationController
{
    public class CommandCreate : IRequest<ReecMessage>
    {
        public CreateNotificationRequest Model { get; }
        public string Code { get; set; }
        public string Header { get; set; }
        public CommandCreate(CreateNotificationRequest createRequest, string code, string header)
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
                string data = ConvertCreateActivityRequestToXML(request.Model);
                await _apiServiceProgrammed.PostAsync<ModelActivityCreate>
                    (request.Code,
                    request.Header,
                    "/sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotification/?sap-client=110",
                    data);
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.CreateMessage);
                return message;
            }
            private string ConvertCreateActivityRequestToXML(CreateNotificationRequest request)
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
                        new XElement(fd + "NotificationText", request.NotificationText),
                        new XElement(fd + "MaintPriority", request.MaintPriority),
                        new XElement(fd + "NotificationType", request.NotificationType),
                        new XElement(fd + "MalfunctionStartDate", request.MalfunctionStartDate),
                        new XElement(fd + "MalfunctionStartTime", request.MalfunctionStartTime),
                        new XElement(fd + "NotificationTimeZone", request.NotificationTimeZone),
                        new XElement(fd + "TechnicalObject", request.TechnicalObject),
                        new XElement(fd + "TechObjIsEquipOrFuncnlLoc", request.TechObjIsEquipOrFuncnlLoc),
                        new XElement(fd + "MaintenanceObjectIsDown", request.MaintenanceObjectIsDown),
                        new XElement(fd + "MainWorkCenter", request.MainWorkCenter),
                        new XElement(fd + "ReportedByUser", request.ReportedByUser)
                        )
                    )
                );
                return root.ToString();
            }
        }
    }
}
