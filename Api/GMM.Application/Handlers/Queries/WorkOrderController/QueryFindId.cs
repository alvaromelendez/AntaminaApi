using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.WorkOrderController;
using MediatR;

namespace GMM.Application.Handlers.Queries.WorkOrderController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdWorkOrder { get; }
        public QueryFindId(Guid idWorkOrder)
        {
            IdWorkOrder = idWorkOrder;
        }

        public class QueryFindIdHandler : IRequestHandler<QueryFindId, FindIdResponse>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public QueryFindIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }

            public async Task<FindIdResponse> Handle(QueryFindId request, CancellationToken cancellationToken)
            {
                //var entity = await _unitOfWork.WorkOrders.AsNoTracking()
                //                .FirstOrDeWorkOrderAsync(x => x.IdWorkOrder == request.IdWorkOrder);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);
                var entity = new ModelWorkOrder()
                {
                    IdWorkOrder = request.IdWorkOrder,
                    Duration = 10,
                    Quantity = 20,
                    ShortText = "ShortText"
                };

                FindIdResponse result = new FindIdResponse();
                result.WorkOrder = _mapper.Map<ModelWorkOrder>(entity);

                return result;
            }
        }
    }
}
