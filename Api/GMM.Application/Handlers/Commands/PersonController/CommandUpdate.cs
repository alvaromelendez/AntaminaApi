using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Request.PersonController;
using GMM.Common.Helpers;
using GMM.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reec.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Commands.PersonController
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

                var isExists = _unitOfWork.Persons.AsNoTracking().Any(t => t.IdPerson == request.Model.Person.IdPerson);
                if (!isExists)
                    throw new ReecException(ReecEnums.Category.Warning, $"No exíste el IdPersona para actualizar.");

                var entity = _mapper.Map<Person>(request.Model.Person);
                entity.RecordEditDate = DateTime.Now;
                var entry = _unitOfWork.Persons.Update(entity);

                if (request.Model.ListAttachedFile != null || request.Model.ListAttachedFile.Count > 0)
                {
                    foreach (var item in request.Model.ListAttachedFile)
                    {
                        var attachedFile = _mapper.Map<AttachedFile>(item);
                        var personFile = new PersonFile
                        {
                            IdPerson = request.Model.Person.IdPerson,
                            IdAttachedFile = attachedFile.IdAttachedFile
                        };

                        switch (item.StatusFile)
                        {
                            case BaseEnums.StatusFile.New:
                                attachedFile.RecordCreationDate = DateTime.Now;
                                _unitOfWork.AttachedFiles.Create(attachedFile);
                                _unitOfWork.PersonFiles.Create(personFile); break;
                            case BaseEnums.StatusFile.NoTouch:
                                break;
                            case BaseEnums.StatusFile.Delete:
                                _unitOfWork.AttachedFiles.Delete(attachedFile);
                                _unitOfWork.PersonFiles.Delete(personFile); break;
                            default:
                                break;
                        }
                    }
                }

                await _unitOfWork.SaveChangesAsync(cancellationToken);
                await transaccion.CommitAsync();

                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.UpdateMessage);
                return message;
            }
        }
    }

}
