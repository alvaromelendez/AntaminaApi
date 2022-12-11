using GMM.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Response.PersonController
{
    public class FindIdResponse
    {
        public ModelPerson Person { get; set; }
        public List<ModelAttachedFile> ListAttachedFile { get; set; }

    }


}
