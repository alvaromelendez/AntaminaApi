﻿using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Request.NotificationController;
using GMM.Common.Helpers;
using MediatR;
using Reec.Inspection;

namespace GMM.Application.Handlers.Commands.NotificationController
{
    public class CommandUpdate : IRequest<ReecMessage>
    {
        public UpdateNotificationRequest Model { get; }
        public CommandUpdate(UpdateNotificationRequest model)
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
                //using var transaccion = await _unitOfWork.TransactionAsync(cancellationToken);

                //var entity = _mapper.Map<Notification>(request.Model.Notification);
                //var entry = _unitOfWork.Notifications.Update(entity);

                //await _unitOfWork.SaveChangesAsync(cancellationToken);
                //await transaccion.CommitAsync();

                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.UpdateMessage);
                return message;
            }
        }
    }
}
