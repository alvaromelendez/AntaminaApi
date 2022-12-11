using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reec.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindAllParent : IRequest<List<ModelMasterTable>>
    {

        public class QueryFindByIdParentIdHandler : IRequestHandler<QueryFindAllParent, List<ModelMasterTable>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindByIdParentIdHandler(IUnitOfWork unitOfWork, IMapper mapper )
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<List<ModelMasterTable>> Handle(QueryFindAllParent request, CancellationToken cancellationToken)
            {

                var listEntity = await _unitOfWork.MasterTables.Queryable()
                                .Where(w => w.IdMasterTableParent == null)
                                .Distinct().AsNoTracking() 
                                .ToListAsync(cancellationToken);
                
                var result = _mapper.Map<List<ModelMasterTable>>(listEntity);
                return result;

            }
        }

    }


}
