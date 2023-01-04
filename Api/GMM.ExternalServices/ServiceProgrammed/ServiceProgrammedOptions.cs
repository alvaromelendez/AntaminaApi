using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.ServiceProgrammed
{

    /// <summary>
    /// Configuración de uri base del api servicio programado y sus endpoint
    /// </summary>
    public class ServiceProgrammedOptions
    {
        public string Uri { get; set; }
         
        public string Authentication_GetDeserializeObject { get; set; }
        public string Authentication_GetSerializeObject { get; set; }
        public string Authentication_GetUserToken { get; set; } 

        public string Security_GetProfileSiapp { get; set; }
        public string Security_GetProfileByCode { get; set; }

        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }

    public class ServiceProgrammedV2Options
    {
        public string Uri { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
