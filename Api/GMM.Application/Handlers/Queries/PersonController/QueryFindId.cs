using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response.PersonController;
using GMM.Common.Helpers;
using GMM.ExternalServices.AwsS3.EndPoint;
using GMM.ExternalServices.AwsS3.Models;
using GMM.ExternalServices.ServiceProgrammed.EndPoint;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Reec.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.PersonController
{
    public class QueryFindId : IRequest<FindIdResponse>
    {
        

        public Guid IdPerson { get; }
        public string Code { get; }
        public string Header { get; }
        public QueryFindId(Guid idPerson, string code, string header)
        {
            IdPerson = idPerson;
            Code = code;
            Header = header;
            
        }

        public class QueryFindIdHandler : IRequestHandler<QueryFindId, FindIdResponse>
        {
            private readonly IFileAws _fileAws;
            private readonly IAuthentication _authentication;
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public QueryFindIdHandler(IUnitOfWork unitOfWork, IMapper mapper,
                IAuthentication authentication,
                IFileAws fileAws)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._authentication = authentication;
                this._fileAws = fileAws;
            }

            public async Task<FindIdResponse> Handle(QueryFindId request, CancellationToken cancellationToken)
            {
                //var entity = await (
                //                 from a in _unitOfWork.Persons.Queryable()
                //                 join b in _unitOfWork.PersonFiles.Queryable()
                //                    on a.IdPerson equals b.IdPerson into rightB

                //                 from bb in rightB.DefaultIfEmpty()
                //                 join c in _unitOfWork.AttachedFiles.Queryable()
                //                    on bb.IdAttachedFile equals c.IdAttachedFile into rightC

                //                 //from cc in rightC.AsEnumerable()
                //                 where a.IdPerson == request.IdPerson
                //                 select new
                //                 {
                //                     Person = a,
                //                     AttachedFiles = rightC.ToList()
                //                 })
                //             .AsNoTracking()
                //             .FirstOrDefaultAsync(cancellationToken);

                var entity = await _unitOfWork.Persons.AsNoTracking()
                                .FirstOrDefaultAsync(x => x.IdPerson == request.IdPerson);

                if (entity == null)
                    throw new ReecException(ReecEnums.Category.BusinessLogic, ConstantMessage.NotExists);

                var attachedFiles = await (
                                        from a in _unitOfWork.PersonFiles.Queryable()
                                        join b in _unitOfWork.AttachedFiles.Queryable()
                                            on a.IdAttachedFile equals b.IdAttachedFile
                                        where a.IdPerson == entity.IdPerson
                                        select b)
                                        .ToListAsync(cancellationToken);

                var header_response = await this._authentication.GetDeserializeObject(
                            new ExternalServices.ServiceProgrammed.Models.EncryptRequest { Code = request.Code, TextTransform = request.Header });

                var rf = JsonConvert.DeserializeObject<TokenAws>(header_response.Result.Value);
                
                foreach (var f in attachedFiles)
                {
                    var fileResponse = new FileResponse(f.PathFile);
                    f.PathFile = this._fileAws.DownloadFileS3(fileResponse.PathFile, rf.AwsAccessKey, rf.AwsSecretKey, rf.AwsSessionToken);
                }

                FindIdResponse result = new FindIdResponse();
                result.Person = _mapper.Map<ModelPerson>(entity);
                result.ListAttachedFile = _mapper.Map<List<ModelAttachedFile>>(attachedFiles);


                return result;
            }
        }


    }

}
