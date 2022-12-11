using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Commands.MasterTableController
{
    public class CommandDelete: IRequest<int>
    {
        public string IdMasterTable { get; }
        public CommandDelete(string idMasterTable)
        {
            IdMasterTable = idMasterTable;
        }

        public class CommandDeleteHandler : IRequestHandler<CommandDelete, int>
        {
            private readonly IUnitOfWork _unitOfWork;

            public CommandDeleteHandler(IUnitOfWork unitOfWork)
            {
                this._unitOfWork = unitOfWork;
            }
            public async Task<int> Handle(CommandDelete request, CancellationToken cancellationToken)
            {
                await _unitOfWork.MasterTables.DeleteAsync(request.IdMasterTable);
                return await _unitOfWork.SaveChangesAsync(cancellationToken);
            }

        }


    }
}
