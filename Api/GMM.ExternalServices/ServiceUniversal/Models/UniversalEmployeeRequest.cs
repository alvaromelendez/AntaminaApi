using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.ServiceUniversal.Models
{
    public class UniversalEmployeeRequest
    {
        public string UserId { set; get; }
        public string Permission { set; get; }
        public string Filter { set; get; }
        public string Location { set; get; }
    }
}
