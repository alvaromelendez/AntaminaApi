using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GMM.Application.Handlers.Queries.ProccessController
{
    public class QueryFindAll : IRequest<List<ModelProccess>>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, List<ModelProccess>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<List<ModelProccess>> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var proccess = await _unitOfWork.Proccess.AsNoTracking().ToListAsync();
                var configurations = await _unitOfWork.ProccessConfigurations.AsNoTracking().ToListAsync();

                var proccess_result = _mapper.Map<List<ModelProccess>>(proccess);
                var configurations_result = _mapper.Map<List<ModelProccessConfiguration>>(configurations);

                proccess_result.Where(x => x.IsEnable).ToList().ForEach(x => x.ProccessConfigurations = configurations_result.Where(y => y.IsEnable && y.IdProccess == x.IdProccess).ToList());

                return proccess_result;
            }
        }
    }
}
