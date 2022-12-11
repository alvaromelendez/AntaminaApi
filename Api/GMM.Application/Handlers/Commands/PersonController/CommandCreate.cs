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
    public class CommandCreate : IRequest<ReecMessage>
    {
        public CreateRequest Model { get; }
        public CommandCreate(CreateRequest createRequest)
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
                using var transaction = await _unitOfWork.TransactionAsync(cancellationToken);
                var isExists = _unitOfWork.Persons.AsNoTracking().Any(t => t.DNI == request.Model.Person.DNI);
                if (isExists)
                    throw new ReecException(ReecEnums.Category.Warning, $"La persona que intenta crear ya existe.");

                var person = _mapper.Map<Person>(request.Model.Person);
                person.RecordCreationDate = DateTime.Now;
                _unitOfWork.Persons.Create(person);

                if (request.Model.ListAttachedFile != null && request.Model.ListAttachedFile.Count > 0)
                {
                    var attachedFiles = _mapper.Map<List<AttachedFile>>(request.Model.ListAttachedFile);
                    person.RecordCreationDate = DateTime.Now;
                    _unitOfWork.AttachedFiles.CreateRange(attachedFiles);

                    var personFiles = attachedFiles.Select(s => new PersonFile
                    {
                        IdAttachedFile = s.IdAttachedFile,
                        IdPerson = person.IdPerson
                    }).ToList();

                    _unitOfWork.PersonFiles.CreateRange(personFiles);
                }

                await _unitOfWork.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.CreateMessage);
                return message;
            }
        }
    }

}
