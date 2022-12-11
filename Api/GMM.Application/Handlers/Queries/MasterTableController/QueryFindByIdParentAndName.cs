using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.MasterTableController;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindByIdParentAndName : IRequest<List<ModelMasterTable>>
    {
        public FindByIdParentAndNameRequest FindByIdParenAndNameRequest { get; }

        public QueryFindByIdParentAndName(FindByIdParentAndNameRequest findByIdParenAndNameRequest)
        {
            FindByIdParenAndNameRequest = findByIdParenAndNameRequest;
        }

       

        public class QueryFindIdHandler : IRequestHandler<QueryFindByIdParentAndName, List<ModelMasterTable>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<List<ModelMasterTable>> Handle(QueryFindByIdParentAndName request, CancellationToken cancellationToken)
            {
                string idMasterTableParent = null;
                if (!string.IsNullOrWhiteSpace(request.FindByIdParenAndNameRequest.IdMasterTableParent))
                    idMasterTableParent = request.FindByIdParenAndNameRequest.IdMasterTableParent.Trim();

                string name = null;
                if (!string.IsNullOrWhiteSpace(request.FindByIdParenAndNameRequest.Name))
                    name = request.FindByIdParenAndNameRequest.Name.Trim();

                var list = await _unitOfWork.MasterTables.Queryable()
                                .Where(w =>
                                    (w.IdMasterTableParent == idMasterTableParent || idMasterTableParent == null) &&
                                    (w.Name.Contains(name) || name == null))
                                .AsNoTracking()
                                .ToListAsync(cancellationToken);

                if (list != null)
                    return _mapper.Map<List<ModelMasterTable>>(list);

                return null;
            }
        }


    }
}
