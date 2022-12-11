using AutoMapper;
using MediatR;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Request.UploadFileController;
using GMM.Application.Models;
using Ent = GMM.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reec.Inspection;
using GMM.Common.Helpers;
using Newtonsoft.Json;
using System.Diagnostics;

namespace GMM.Application.Handlers.Commands.UploadFileController
{
    public class CommandCreate : IRequest<ReecMessage>
    {
        public UploadRequest Model { get; }
        public CommandCreate(UploadRequest createRequest)
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
                try
                {
                    List<Ent.UploadFile> data = new List<Ent.UploadFile>();
                    using var transaction = await _unitOfWork.TransactionAsync(cancellationToken);
                    List<List<string>> arrData = JsonConvert.DeserializeObject<List<List<string>>>(request.Model.JsonExcel);

                    //Convertir string a List<T>
                    foreach (var item in arrData)
                    {
                        Ent.UploadFile entData = new Ent.UploadFile();
                        for (int i = 0; i < item.Count(); i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    entData.Id = int.Parse(item[i].ToString());
                                    break;
                                case 1:
                                    entData.Description = item[i].ToString();
                                    break;
                                case 2:
                                    entData.Brand = item[i].ToString();
                                    break;
                                case 3:
                                    entData.Model = item[i].ToString();
                                    break;
                                case 4:
                                    entData.Quantity = int.Parse(item[i].ToString());
                                    break;
                                case 5:
                                    // En el segundo parametro de ParseExact, modificar el formato según la fecha 
                                    entData.RegistryDate = DateTime.ParseExact(item[i].ToString(),"M/d/y", null);
                                    break;
                                default:
                                    break;
                            }
                        }
                        data.Add(entData);
                    }

                        request.Model.ListUploadFile = data;

                    if (request.Model.ListUploadFile != null && request.Model.ListUploadFile.Count > 0)
                    {
                        var attachedFiles = _mapper.Map<List<Ent.UploadFile>>(request.Model.ListUploadFile);
                        var updattachedFiles = attachedFiles.Select(s => new Ent.UploadFile
                        {
                            Id = s.Id,
                            Description = s.Description,
                            Brand = s.Brand,
                            Model = s.Model,
                            Quantity = s.Quantity,
                            RegistryDate = s.RegistryDate
                        }).ToList();
                        try
                        {
                            _unitOfWork.UploadFiles.CreateRange(updattachedFiles);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                        } 
                    }

                    await _unitOfWork.SaveChangesAsync(cancellationToken);
                    await transaction.CommitAsync(cancellationToken);

                    var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.CreateMessage);
                    return message;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
              

            }
        }
    }
}
