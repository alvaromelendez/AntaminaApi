using GMM.Application.Interfaces.Repositories;
using GMM.Common.Helpers;
using MediatR;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.DocumentController
{
    public class CommandDelete : IRequest<ReecMessage>
    {
        public Guid IdDocument { get; }
        public CommandDelete(Guid idDocument)
        {
            this.IdDocument = IdDocument;
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
                //var entity = await _unitOfWork.Documents.FindAsync(request.IdDocument);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);

                //_unitOfWork.Documents.Delete(entity);
                //await _unitOfWork.SaveChangesAsync(cancellationToken);
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.DeleteMessage);
                return message;
            }

        }
    }
}
