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
using Microsoft.EntityFrameworkCore;

namespace GMM.Application.Handlers.Commands.MasterTableController
{
    public class CommandUpdate : IRequest<ModelMasterTable>
    {
        public ModelMasterTable ModelMasterTable { get; }
        public CommandUpdate(ModelMasterTable modelMasterTable)
        {
            ModelMasterTable = modelMasterTable;
        }

        public class CommandUpdateHandler : IRequestHandler<CommandUpdate, ModelMasterTable>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public CommandUpdateHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<ModelMasterTable> Handle(CommandUpdate request, CancellationToken cancellationToken)
            {
                var isExists = await _unitOfWork.MasterTables.AsNoTracking()
                                .FirstOrDefaultAsync(t => t.IdMasterTable == request.ModelMasterTable.IdMasterTable);
                
                if (isExists == null)
                    throw new ReecException(ReecEnums.Category.Warning, "No exíste el registro.");


                var entity = _mapper.Map<Ent.MasterTable>(request.ModelMasterTable);
                entity.RecordEditDate = DateTime.Now;
                var entry = _unitOfWork.MasterTables.Update(entity);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
                
                var result = _mapper.Map<ModelMasterTable>(entry.Entity);
                return result;

            }
        }


    }

}
