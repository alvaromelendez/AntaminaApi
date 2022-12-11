namespace GMM.Application.Response
{
    public class ExportFileBase64
    {
        public string ContentType { get; set; }

        /// <summary>
        /// Nombre del archivo y debe contener la extensión del archivo.
        /// <para>Ejemplo: documento.pdf</para>
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Archivo expresado en una cadena de Base64.
        /// </summary>
        public string FileBase64 { get; set; }

    }


}
