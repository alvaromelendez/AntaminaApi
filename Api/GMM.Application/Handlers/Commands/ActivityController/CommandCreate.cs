using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.ActivityController;
using GMM.Application.Response.ActivityController;
using GMM.Common.Helpers;
using GMM.Domain.Entities;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;
using Reec.Inspection;
using System.Xml.Linq;

namespace GMM.Application.Handlers.Commands.ActivityController
{
    public class CommandCreate : IRequest<ReecMessage>
    {
        public CreateActivityRequest Model { get; }
        public string Code { get; set; }
        public string Header { get; set; }
        public CommandCreate(CreateActivityRequest createRequest, string code, string header)
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
                    "/sap/opu/odata/sap/API_MAINTNOTIFICATION/MaintenanceNotificationItem(MaintenanceNotification='10000381',MaintenanceNotificationItem='1')/to_ItemActivity/?sap-client=110",
                    data);                
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.CreateMessage);
                return message;
            }

            private string ConvertCreateActivityRequestToXML(CreateActivityRequest request)
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
                        new XElement(fd + "MaintNotificationActivity", request.MaintNotificationActivity),
                        new XElement(fd + "MaintenanceNotification", request.MaintenanceNotification),
                        new XElement(fd + "MaintenanceNotificationItem", request.MaintenanceNotificationItem),
                        new XElement(fd + "MaintNotifActivitySortNumber", request.MaintNotifActivitySortNumber),
                        new XElement(fd + "MaintNotifActyTxt", request.MaintNotifActyTxt),
                        new XElement(fd + "MaintNotifActivityCodeGroup", request.MaintNotifActivityCodeGroup),
                        new XElement(fd + "NotifActivityCodeGroupText", request.NotifActivityCodeGroupText),
                        new XElement(fd + "MaintNotificationActivityCode", request.MaintNotificationActivityCode),
                        new XElement(fd + "NotifActivityCodeText", request.NotifActivityCodeText),
                        new XElement(fd + "PlannedStartDate", request.PlannedStartDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")),
                        new XElement(fd + "PlannedStartTime", request.PlannedStartTime),
                        new XElement(fd + "PlannedEndDate", null, new XAttribute(fc + "null", "true")),
                        new XElement(fd + "PlannedEndTime", request.PlannedEndTime),
                        new XElement(fd + "IsDeleted", request.IsDeleted)
                        )
                    )
                );
                return root.ToString();
            }
        }
    }
}
