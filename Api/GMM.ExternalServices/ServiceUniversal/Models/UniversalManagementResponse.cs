using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.ServiceUniversal.Models
{
    public class UniversalManagementResponse
    {
        public string Level { get; set; }
        public string Area { get; set; }
        public string CodeManagement { get; set; }
        public string CodeManagementSuperior { get; set; }
        public string RecordStatus { get; set; }
    }
}
