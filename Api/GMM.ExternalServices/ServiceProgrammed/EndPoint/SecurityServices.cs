using GMM.ExternalServices.ServiceProgrammed.Base;
using GMM.ExternalServices.ServiceProgrammed.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.ServiceProgrammed.EndPoint
{
    public class SecurityServices : ISecurityServices
    {
        private readonly IApiServiceProgrammed _apiServiceProgrammed;
        private readonly ServiceProgrammedOptions _serviceProgrammed;

        public SecurityServices(IApiServiceProgrammed apiServiceProgrammed,
                                ServiceProgrammedOptions serviceProgrammed)
        {
            this._apiServiceProgrammed = apiServiceProgrammed;
            this._serviceProgrammed = serviceProgrammed;
        }

        public async Task<ApiGenericResponse<Response<string>>> GetProfileByCode(string code, string header)
        {
            var url = this._serviceProgrammed.Security_GetProfileByCode;
            return await _apiServiceProgrammed.PostAsync<Response<string>>(code, header, url, null);
        }

        public async Task<ApiGenericResponse<Response<string>>> GetProfileSiapp(string code, string header)
        {
            var url = this._serviceProgrammed.Security_GetProfileSiapp;
            return await _apiServiceProgrammed.PostAsync<Response<string>>(code, header, url, null);
        }
    }
}
