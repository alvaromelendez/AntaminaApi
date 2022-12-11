using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response;
using GMM.Common.Excel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Table;
using Reec.Helpers;
using Reec.Inspection;
using System.Text;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindAllAndDownloadExcel: IRequest<ExportFileByte>
    {

        public class QueryFindAllAndDownloadExcelHandler : IRequestHandler<QueryFindAllAndDownloadExcel, ExportFileByte>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IGenerateExcel _generateExcel;

            public QueryFindAllAndDownloadExcelHandler(IUnitOfWork unitOfWork, IMapper mapper, IGenerateExcel generateExcel)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._generateExcel = generateExcel;
            }
            public async Task<ExportFileByte> Handle(QueryFindAllAndDownloadExcel request, CancellationToken cancellationToken)
            {
                var entities = await _unitOfWork.MasterTables.AsNoTracking().ToListAsync();
                var result = _mapper.Map<List<ModelMasterTable>>(entities);
                if (result != null && result.Count == 0)
                    throw new ReecException(ReecEnums.Category.PartialContent, "No se encontraron registros");

                var bytes = this._generateExcel.SaveToBytes(result, true, TableStyles.Medium2);
                var fileName = $"{nameof(QueryFindAllAndDownloadExcel)}.xlsx";

                var file = new ExportFileByte()
                {
                    ContentType = HelperContentType.GetContentType(fileName),
                    FileBytes = bytes,
                    FileName = fileName
                };
                return file;
            }
        }

    }

}
