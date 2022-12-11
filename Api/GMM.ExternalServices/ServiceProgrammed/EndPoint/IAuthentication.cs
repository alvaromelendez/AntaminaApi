using GMM.ExternalServices.ServiceProgrammed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.ServiceProgrammed.EndPoint
{
    public interface IAuthentication
    {


        /// <summary>
        /// Petición Post(URL: /api/Authentication/GetDeserializeObject)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<Response<string>>> GetDeserializeObject(EncryptRequest entity);

        /// <summary>
        /// Petición Post(URL: /api/Authentication/GetSerializeObject
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<Response<string>>> GetSerializeObject(EncryptRequest entity);

        /// <summary>
        /// Petición Post(URL: /api/Authentication/GetUserToken
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<bool>> GetUserToken(LoginRequest entity);

         

        BaseRequest GetObjectTransform(string header);
    }


}
