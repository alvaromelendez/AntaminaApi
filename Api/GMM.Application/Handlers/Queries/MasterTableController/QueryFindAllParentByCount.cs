using GMM.Application.Interfaces.Repositories;
using GMM.Application.Response.MasterTableController;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindAllParentByCount : IRequest<List<FindAllParentByCountResponse>>
    {

        public class QueryFindAllParentByCountHandler : IRequestHandler<QueryFindAllParentByCount, List<FindAllParentByCountResponse>>
        {
            private readonly IUnitOfWork _unitOfWork;

            public QueryFindAllParentByCountHandler(IUnitOfWork unitOfWork)
            {
                this._unitOfWork = unitOfWork;
            }


            public async Task<List<FindAllParentByCountResponse>> Handle(QueryFindAllParentByCount request, CancellationToken cancellationToken)
            {

                var nuevo = await (from a in _unitOfWork.MasterTables.Queryable()
                                   join b in _unitOfWork.MasterTables.Queryable()
                                       on a.IdMasterTableParent equals b.IdMasterTable into rightB
                                   from bb in rightB.DefaultIfEmpty() 
                                   group a by new { a.IdMasterTableParent, bb.Name } into g
                                   select new FindAllParentByCountResponse
                                   {
                                       Count = g.Count(),
                                       Name = g.Key.Name
                                   })
                                .AsNoTracking()
                                .ToListAsync(cancellationToken);

                return nuevo;
            }
        }

    }

}
