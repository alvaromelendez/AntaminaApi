using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindAll: IRequest<List<ModelMasterTable>>
    {

        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<ModelMasterTable>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<List<ModelMasterTable>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var entities = await _unitOfWork.MasterTables.AsNoTracking().ToListAsync();
                var result = _mapper.Map<List<ModelMasterTable>>(entities);
                return result;
            }
        }

    }

}
