using GMM.Application.Interfaces.Repositories;
using GMM.Common.Helpers;
using MediatR;
using Reec.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Commands.ActivityController
{
    public class CommandDelete : IRequest<ReecMessage>
    {
        public Guid IdActivity { get; }
        public CommandDelete(Guid idActivity)
        {
            this.IdActivity = IdActivity;
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
                //var entity = await _unitOfWork.Activities.FindAsync(request.IdActivity);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);

                //_unitOfWork.Activities.Delete(entity);
                //await _unitOfWork.SaveChangesAsync(cancellationToken);
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.DeleteMessage);
                return message;
            }

        }
    }
}
