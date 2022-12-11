using GMM.ExternalServices.ServiceProgrammed.Base;
using GMM.ExternalServices.ServiceProgrammed.Models;
using Newtonsoft.Json;

namespace GMM.ExternalServices.ServiceProgrammed.EndPoint
{
    public class Authentication : IAuthentication
    {
        private readonly IApiServiceProgrammed _apiServiceProgrammed;
        private readonly ServiceProgrammedOptions _serviceProgrammed;

        public Authentication(IApiServiceProgrammed apiServiceProgrammed,
                                ServiceProgrammedOptions serviceProgrammed)
        {
            this._apiServiceProgrammed = apiServiceProgrammed;
            this._serviceProgrammed = serviceProgrammed;
        }

        public async Task<ApiGenericResponse<Response<string>>> GetDeserializeObject(EncryptRequest entity)
        {
            var url = this._serviceProgrammed.Authentication_GetDeserializeObject;
            return await _apiServiceProgrammed.PostAnonymousAsync<Response<string>>(url, entity);
        }
        public BaseRequest GetObjectTransform(string header)
        {
            return JsonConvert.DeserializeObject<BaseRequest>(header);
        }

        public async Task<ApiGenericResponse<Response<string>>> GetSerializeObject(EncryptRequest entity)
        {
            var url = this._serviceProgrammed.Authentication_GetSerializeObject;
            return await _apiServiceProgrammed.PostAnonymousAsync<Response<string>>(url, entity);
        }

        public async Task<ApiGenericResponse<bool>> GetUserToken(LoginRequest entity)
        {
            var url = this._serviceProgrammed.Authentication_GetUserToken;
            return await _apiServiceProgrammed.PostAnonymousAsync<bool>(url, entity);
        }
    }
}
