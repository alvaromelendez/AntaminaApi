using GMM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Response.OffLineController
{
    public class OffLineResponse
    {  
        public List<ModelMasterTable> ListMasterTable { get; set; }
        public List<ModelMasterTable> ListMasterTableParent { get; set; } 

    }

}
