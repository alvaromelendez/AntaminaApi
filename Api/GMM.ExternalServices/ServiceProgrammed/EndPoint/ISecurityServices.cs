
using GMM.ExternalServices.ServiceProgrammed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.ServiceProgrammed.EndPoint
{
    public interface ISecurityServices
    {

        /// <summary>
        /// Petición de URL(POST): /api/Security/GetProfileByCode
        /// </summary>
        /// <param name="code"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<Response<string>>> GetProfileByCode(string code, string header);


        /// <summary>
        /// Petición de URL(POST): /api/Security/GetProfileSiapp
        /// </summary>
        /// <param name="code"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<Response<string>>> GetProfileSiapp(string code, string header);
            
    }

}
