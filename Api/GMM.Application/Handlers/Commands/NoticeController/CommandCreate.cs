using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Request.NotificationController;
using GMM.Common.Helpers;
using MediatR;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.NotificationController
{
    public class CommandCreate : IRequest<ReecMessage>
    {
        public CreateNotificationRequest Model { get; }
        public CommandCreate(CreateNotificationRequest createRequest)
        {
            Model = createRequest;
        }

        public class CommandCreateHandler : IRequestHandler<CommandCreate, ReecMessage>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public CommandCreateHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<ReecMessage> Handle(CommandCreate request, CancellationToken cancellationToken)
            {
                //using var transaction = await _unitOfWork.TransactionAsync(cancellationToken);
              
                //var Notification = _mapper.Map<Notification>(request.Model.Notification);
                //_unitOfWork.Notifications.Create(Notification);

                //await _unitOfWork.SaveChangesAsync(cancellationToken);
                //await transaction.CommitAsync(cancellationToken);

                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.CreateMessage);
                return message;
            }
        }
    }
}
