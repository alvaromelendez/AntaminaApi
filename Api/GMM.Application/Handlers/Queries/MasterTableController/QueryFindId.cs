using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindId : IRequest<ModelMasterTable>
    {
        public string IdMasterTable { get; }
        public QueryFindId(string idMasterTable)
        {
            IdMasterTable = idMasterTable;
        }

        public class QueryFindIdHandler : IRequestHandler<QueryFindId, ModelMasterTable>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<ModelMasterTable> Handle(QueryFindId request, CancellationToken cancellationToken)
            {
                var entity = await _unitOfWork.MasterTables.FindAsync(request.IdMasterTable);
                if (entity != null)
                    return _mapper.Map<ModelMasterTable>(entity);

                return null;
            }
        }


    }
}
