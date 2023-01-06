
namespace GMM.ExternalServices.ServiceProgrammed.Base
{
    public interface IApiServiceProgrammed
    {
        /// <summary>
        /// Obtener de forma asincrona los resultados de una pedticionj HTTPGet enviando UserName:UserPassword
        /// </summary>
        /// <typeparam name="TypeObject"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<TypeObject>> GetAsync<TypeObject>(string url) where TypeObject : class;

        /// <summary>
        /// Enviar de forma asincrona
        /// </summary>
        /// <typeparam name="TypeObject"></typeparam>
        /// <param name="code"></param>
        /// <param name="header"></param>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<TypeObject>> PostAsync<TypeObject>(string code, string header, string url, string data) where TypeObject : class;

        /// <summary>
        /// Obtener de forma asíncrona los resultados de una peticion HttpGet enviando datos de cabecera.
        /// </summary>
        /// <typeparam name="TypeObject">Tipo de objeto que retorna el API en la propiedad Result</typeparam>
        /// <param name="code"></param>
        /// <param name="header"></param>
        /// <param name="url">Ejemplo: api/[controller]/[action]</param>
        /// <returns></returns>
        Task<ApiGenericResponse<TypeObject>> GetAsync<TypeObject>(string code, string header, string url) where TypeObject : class;


        /// <summary>
        /// Obtener de forma asíncrona los resultados de una peticion HttpPost enviando datos de cabecera.
        /// </summary>
        /// <typeparam name="TypeObject"></typeparam>
        /// <param name="code"></param>
        /// <param name="header"></param>
        /// <param name="url"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<TypeObject>> PostAsync<TypeObject>(string code, string header, string url, object entity) where TypeObject : class;


        /// <summary>
        /// Obtener de forma asíncrona los resultados de una peticion HttpPost.
        /// </summary>
        /// <typeparam name="TypeObject"></typeparam>
        /// <param name="url"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<TypeObject>> PostAnonymousAsync<TypeObject>(string url, object entity);

        /// <summary>
        /// Obtener de forma asincrona los resultados de una pedticionj HTTPGet enviando UserName:UserPassword
        /// </summary>
        /// <typeparam name="TypeObject"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        Task<string> GetToken(string endpoint);
    }

    public interface IApiServiceProgrammedV2
    {
        /// <summary>
        /// Obtener de forma asincrona los resultados de una pedticionj HTTPGet enviando UserName:UserPassword
        /// </summary>
        /// <typeparam name="TypeObject"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        Task<ApiGenericResponse<TypeObject>> GetAsync<TypeObject>(string url) where TypeObject : class;
    }
}