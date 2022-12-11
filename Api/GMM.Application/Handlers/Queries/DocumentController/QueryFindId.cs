using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.DocumentController;
using MediatR;

namespace GMM.Application.Handlers.Queries.DocumentController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        public Guid IdDocument { get; }
        public QueryFindId(Guid idDocument)
        {
            IdDocument = idDocument;
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
                //var entity = await _unitOfWork.Documents.AsNoTracking()
                //                .FirstOrDeDocumentAsync(x => x.IdDocument == request.IdDocument);
                //if (entity == null)
                //    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);
                var entity = new ModelDocument()
                {
                    IdDocument = request.IdDocument
                };

                FindIdResponse result = new FindIdResponse();
                result.Document = _mapper.Map<ModelDocument>(entity);

                return result;
            }
        }
    }
}
