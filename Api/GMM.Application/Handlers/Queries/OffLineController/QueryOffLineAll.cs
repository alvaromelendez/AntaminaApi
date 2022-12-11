using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.OffLineController;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.OffLineController
{
    public class QueryOffLineAll : IRequest<OffLineResponse>
    {

        public class QueryOffLineAllHandler : IRequestHandler<QueryOffLineAll, OffLineResponse>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryOffLineAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<OffLineResponse> Handle(QueryOffLineAll request, CancellationToken cancellationToken)
            {
                OffLineResponse response = new OffLineResponse();
                var listMasterTable = await _unitOfWork.MasterTables.AsNoTracking().ToListAsync(cancellationToken);

                var listParent = await _unitOfWork.MasterTables.Queryable()
                                .Where(w => w.IdMasterTableParent == null)
                                .Distinct().AsNoTracking()
                                .ToListAsync(cancellationToken);

                response.ListMasterTable = _mapper.Map<List<ModelMasterTable>>(listMasterTable);
                response.ListMasterTableParent = _mapper.Map<List<ModelMasterTable>>(listParent);

                return response;
            }
        }

    }

}
