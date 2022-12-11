using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Application.Response;
using GMM.Common.Excel;
using GMM.Common.Helpers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Table;
using Reec.Helpers;
using Reec.Inspection;
using System.Drawing;
using System.Net;
using System.Text;

namespace GMM.Application.Handlers.Queries.MasterTableController
{
    public class QueryFindAllJsonExcel: IRequest<ExportFileBase64>
    {

        public class QueryFindAllJsonExcelHandler : IRequestHandler<QueryFindAllJsonExcel, ExportFileBase64>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IGenerateExcel _generateExcel;
            private readonly IMasterTableRepository _masterTableRepository;

            public QueryFindAllJsonExcelHandler(IUnitOfWork unitOfWork, IMapper mapper, IGenerateExcel generateExcel, IMasterTableRepository masterTableRepository)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                this._generateExcel = generateExcel;
                this._masterTableRepository = masterTableRepository;
            }
            public async Task<ExportFileBase64> Handle(QueryFindAllJsonExcel request, CancellationToken cancellationToken)
            {
                var result = await
                (from a in _unitOfWork.MasterTables.Queryable()
                 select new
                 {
                     IdMasterTable = a.IdMasterTable,
                     IdMasterTableParent = a.IdMasterTableParent,
                     Name = a.Name,
                     Order = a.Order,
                     Value = a.Value,
                     Status = a.RecordStatus == ConstantBase.Active ? ConstantBase.ActiveDescription : ConstantBase.InactiveDescription,
                     UserRecordCreation = a.UserRecordCreation,
                     RecordCreationDate = a.RecordCreationDate.ToString("dd/MM/yyyy HH:mm"),
                     UserEditRecord = a.UserEditRecord,
                     RecordEditDate = a.RecordEditDate.HasValue ? a.RecordEditDate.Value.ToString("dd/MM/yyyy HH:mm") : string.Empty
                 }).ToListAsync(cancellationToken);

                if (result != null && result.Count == 0)
                    throw new ReecException(ReecEnums.Category.PartialContent, "No se encontraron registros");

                var urlAntamina = await _masterTableRepository.FindId(ConstantMasterTable.UrlGenerales.LogoAntamina, cancellationToken);

                Image img = null;
                if (urlAntamina != null)
                {
                    using (var webClient = new WebClient())
                    {
                        byte[] data = webClient.DownloadData(urlAntamina.Value);

                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            img = Image.FromStream(mem);
                        }
                    }
                }

                var titles = new string[12];
                titles[0] = "ID";
                titles[1] = "ID Padre";
                titles[2] = "Nombre";
                titles[3] = "Orden";
                titles[4] = "Valor";
                titles[5] = "Estado";
                titles[6] = "Usuario Creador";
                titles[7] = "Fecha Creación";
                titles[8] = "Usuario Modificador";
                titles[9] = "Fecha Modificador";

                var bytes = this._generateExcel.SaveToBytes(result, true, TableStyles.Medium2, img, "Reporte Master Table", titles);
                var fileName = string.Format("Reporte_Master_Table_{0}.xlsx", DateTime.Now.ToString("yyyy_MM_dd_hh_mm"));

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
