using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;

namespace GMM.Application.Handlers.Queries.WorkOrderController
{
    public class QueryFindAll : IRequest<List<ModelWorkOrder>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<ModelWorkOrder>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }

            public async Task<List<ModelWorkOrder>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                //var listEntity = await _unitOfWork.WorkOrders.AsNoTracking().ToListAsync(cancellationToken);
                //if (listEntity == null || listEntity.Count == 0)
                //    throw new ReecException(ReecEnums.Category.PartialContent, ConstantMessage.NotRecords);
                var listEntity = new List<ModelWorkOrder>() {
                  new ModelWorkOrder()
                  {
                    IdWorkOrder = Guid.NewGuid(),
                    Duration = 10,
                    Quantity = 20,
                    ShortText = "ShortText"
                 },
                 new ModelWorkOrder()
                 {
                    IdWorkOrder = Guid.NewGuid(),
                    Duration = 2,
                    Quantity = 12,
                    ShortText = "ShortText"
                }};

                var result = _mapper.Map<List<ModelWorkOrder>>(listEntity);
                return result;
            }
        }
    }
}
