using GMM.Application.Models;
using GMM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Request.UploadFileController
{
    public class UploadRequest
    {
        public UploadFile UploadFiless { get; set; }

        public List<UploadFile> ListUploadFile { get; set; }

        public string HeaderExcelArray { get; set; }
        public string JsonExcel { get; set; }
        public string NameExcel { get; set; }
        public string HeaderExcel { get; set; }


    }
}
