using AutoMapper;
using MediatR;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using Ent = GMM.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.MasterTableController
{
    public class CommandCreate : IRequest<ModelMasterTable>
    {
        public ModelMasterTable ModelMasterTable { get; }
        public CommandCreate(ModelMasterTable modelMasterTable)
        {
            ModelMasterTable = modelMasterTable;
        }


        public class CommandCreateHandler : IRequestHandler<CommandCreate, ModelMasterTable>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public CommandCreateHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }

            public async Task<ModelMasterTable> Handle(CommandCreate request, CancellationToken cancellationToken)
            {
                var isExists = await _unitOfWork.MasterTables.FindAsync(request.ModelMasterTable.IdMasterTable);
                if (isExists != null)
                    throw new ReecException(ReecEnums.Category.Warning, "No puede agregar un registro duplicado.");

                var entity = _mapper.Map<Ent.MasterTable>(request.ModelMasterTable);
                entity.RecordCreationDate = DateTime.Now;

                _unitOfWork.MasterTables.Create(entity);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                var result = _mapper.Map<ModelMasterTable>(entity);

                return result;
            }
        }
    }

}
