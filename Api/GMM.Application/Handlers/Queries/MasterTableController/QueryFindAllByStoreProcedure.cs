using GMM.Application.Interfaces.Services;
using GMM.Application.Response;
using GMM.Common.Excel;
using MediatR;
using OfficeOpenXml.Table;
using Reec.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindAllByStoreProcedure : IRequest<ExportFileBase64>
    {

        public class QueryFindAllByStoreProcedureHandler : IRequestHandler<QueryFindAllByStoreProcedure, ExportFileBase64>
        {
            private readonly IMasterTableServices _masterTableServices;
            private readonly IGenerateExcel _generateExcel;

            public QueryFindAllByStoreProcedureHandler(IMasterTableServices masterTableServices, IGenerateExcel generateExcel )
            {
                this._masterTableServices = masterTableServices;
                this._generateExcel = generateExcel;
            }

            public async Task<ExportFileBase64> Handle(QueryFindAllByStoreProcedure request, CancellationToken cancellationToken)
            {

                using var dt = await _masterTableServices.FindAllByStoreProcedure(cancellationToken);
                var bytes = _generateExcel.SaveToBytes(dt, true, TableStyles.Medium2);
                var fileName = $"FindAllByStoreProcedure.xlsx";

                var file = new ExportFileBase64()
                {
                    ContentType = HelperContentType.GetContentType(fileName),
                    FileBase64 = Convert.ToBase64String(bytes),
                    FileName = fileName
                };

                return file;
            }
        }

    }

}
