using Amazon.S3.Model;
using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.ExternalServices.ServiceProgrammed.Base;
using MediatR;

namespace GMM.Application.Handlers.Queries.EquipmentController
{
    public class QueryFindAll : IRequest<Equipment>
    {
        public class QueryFindAllHandler : IRequestHandler<QueryFindAll, Equipment>
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
            public async Task<Equipment> Handle(QueryFindAll request, CancellationToken cancellationToken)
            {
                var response = await _apiServiceProgrammed.GetAsync<IEnumerable<ModelEquipment>>("api/Execute/Comando/SAP/GMM/SearchEquipment?InputReq=Equipment:HTENG");
                return new Equipment() { Equipments = _mapper.Map<IEnumerable<ModelEquipment>>(response.Result) };
            }
        }
    }
}
