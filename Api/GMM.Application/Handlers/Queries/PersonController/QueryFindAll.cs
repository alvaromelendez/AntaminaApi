using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Common.Helpers;
using GMM.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reec.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.PersonController
{
    public class QueryFindAll : IRequest<List<ModelPerson>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<ModelPerson>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }


            public async Task<List<ModelPerson>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var listEntity = await _unitOfWork.Persons.AsNoTracking().ToListAsync(cancellationToken);
                if (listEntity == null || listEntity.Count == 0)                
                    throw new ReecException(ReecEnums.Category.PartialContent, ConstantMessage.NotRecords);
                
                var result = _mapper.Map<List<ModelPerson>>(listEntity);
                return result;
            }
        }
    }


}
