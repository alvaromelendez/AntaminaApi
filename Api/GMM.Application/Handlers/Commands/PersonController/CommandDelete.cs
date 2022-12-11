using GMM.Application.Interfaces.Repositories;
using GMM.Common.Helpers;
using MediatR;
using Reec.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Commands.PersonController
{
    public class CommandDelete : IRequest<ReecMessage>
    {
        public Guid IdPerson { get; }
        public CommandDelete(Guid idPerson)
        {
            this.IdPerson = idPerson;
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
                var entity = await _unitOfWork.Persons.FindAsync(request.IdPerson);
                if (entity == null)
                    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);

                _unitOfWork.Persons.Delete(entity);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.DeleteMessage);
                return message;
            }

        }
    }

}

