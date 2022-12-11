using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Request.ProccessConfigurationController;
using GMM.Common.Helpers;
using GMM.Domain.Entities;
using MediatR;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.ProccessConfiguration
{
    public class CommandUpdate : IRequest<ReecMessage>
    {
        public UpdateRequest Model { get; }
        public CommandUpdate(UpdateRequest model)
        {
            this.Model = model;
        }

        public class CommandUpdateHandler : IRequestHandler<CommandUpdate, ReecMessage>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public CommandUpdateHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<ReecMessage> Handle(CommandUpdate request, CancellationToken cancellationToken)
            {
                using var transaccion = await _unitOfWork.TransactionAsync(cancellationToken);

                var isExists = _unitOfWork.ProccessConfigurations.AsNoTracking().Any(t => t.IdProccessConfiguration == request.Model.ProccessConfiguration.IdProccessConfiguration);
                if (!isExists)
                    throw new ReecException(ReecEnums.Category.Warning, $"No exíste el IdProcessConfiguration para actualizar.");

                var entity = _mapper.Map<GMM.Domain.Entities.ProccessConfiguration>(request.Model.ProccessConfiguration);
                var entry = _unitOfWork.ProccessConfigurations.Update(entity);

                await _unitOfWork.SaveChangesAsync(cancellationToken);
                await transaccion.CommitAsync();

                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.UpdateMessage);
                return message;
            }
        }
    }
}
