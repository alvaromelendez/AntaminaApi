using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.FunctionalLocationController
{
    public class QueryFindAll : IRequest<FunctionalLocation>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, FunctionalLocation>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IApiServiceProgrammedV2 _apiServiceProgrammed;
            public QueryFindAllHandler(IUnitOfWork unitOfWork, IMapper mapper, IApiServiceProgrammedV2 apiServiceProgrammed)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._apiServiceProgrammed = apiServiceProgrammed;
            }
            public async Task<FunctionalLocation> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<IEnumerable<ModelFunctionalLocation>>("api/Execute/Comando/SAP/GMM/SearchFunctionalLocation?InputReq=FunctionalLocation:A-01-01-04-A18-HT0060");                
               return new FunctionalLocation() { FunctionalLocations = _mapper.Map<IEnumerable<ModelFunctionalLocation>>(response.Result) };
            }
        }
    }
}
