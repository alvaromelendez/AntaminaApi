using GMM.Application.Interfaces.Repositories;
using GMM.Common.Helpers;
using MediatR;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.WorkOrderController
{
    public class CommandDelete : IRequest<ReecMessage>
    {
        public Guid IdWorkOrder { get; }
        public CommandDelete(Guid idWorkOrder)
        {
            this.IdWorkOrder = IdWorkOrder;
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
                //var entity = await _unitOfWork.WorkOrders.FindAsync(request.IdWorkOrder);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);

                //_unitOfWork.WorkOrders.Delete(entity);
                //await _unitOfWork.SaveChangesAsync(cancellationToken);
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.DeleteMessage);
                return message;
            }

        }
    }
}
