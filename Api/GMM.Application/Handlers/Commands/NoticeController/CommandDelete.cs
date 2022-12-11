using GMM.Application.Interfaces.Repositories;
using GMM.Common.Helpers;
using MediatR;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.NotificationController
{
    public class CommandDelete : IRequest<ReecMessage>
    {
        public Guid IdNotification { get; }
        public CommandDelete(Guid idNotification)
        {
            this.IdNotification = IdNotification;
        }

        public class CommandDeleteHandler : IRequestHandler<CommandDelete, ReecMessage>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CommandDeleteHandler(IUnitOfWork unitOfWork)
            {
                this._unitOfWork = unitOfWork;
            }
            public async Task<ReecMessage> Handle(CommandDelete request, CancellationToken cancellationToken)
            {
                //var entity = await _unitOfWork.Notifications.FindAsync(request.IdNotification);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);

                //_unitOfWork.Notifications.Delete(entity);
                //await _unitOfWork.SaveChangesAsync(cancellationToken);
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.DeleteMessage);
                return message;
            }

        }
    }
}
