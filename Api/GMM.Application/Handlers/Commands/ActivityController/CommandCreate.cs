using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Request.ActivityController;
using GMM.Common.Helpers;
using GMM.Domain.Entities;
using MediatR;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.ActivityController
{
    public class CommandCreate : IRequest<ReecMessage>
    {
        public CreateActivityRequest Model { get; }
        public CommandCreate(CreateActivityRequest createRequest)
        {
            Model = createRequest;
        }

        public class CommandCreateHandler : IRequestHandler<CommandCreate, ReecMessage>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public CommandCreateHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
            public async Task<ReecMessage> Handle(CommandCreate request, CancellationToken cancellationToken)
            {
                //using var transaction = await _unitOfWork.TransactionAsync(cancellationToken);
              
                //var Activity = _mapper.Map<Activity>(request.Model.Activity);
                //_unitOfWork.Activities.Create(Activity);

                //await _unitOfWork.SaveChangesAsync(cancellationToken);
                //await transaction.CommitAsync(cancellationToken);

                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.CreateMessage);
                return message;
            }
        }
    }
}
