using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.DocumentController
{
    public class QueryFindAll : IRequest<List<ModelDocument>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<ModelDocument>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }


            public async Task<List<ModelDocument>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                //var listEntity = await _unitOfWork.Documents.AsNoTracking().ToListAsync(cancellationToken);
                //if (listEntity == null || listEntity.Count == 0)
                //    throw new ReecException(ReecEnums.Category.PartialContent, ConstantMessage.NotRecords);
                var listEntity = new List<ModelDocument>() {
                  new ModelDocument(){ IdDocument = Guid.NewGuid() },
                  new ModelDocument(){ IdDocument = Guid.NewGuid() }
                };
                var result = _mapper.Map<List<ModelDocument>>(listEntity);
                return result;
            }
        }
    }
}
