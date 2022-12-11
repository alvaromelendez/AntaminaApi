namespace GMM.Application.Response
{
    public class ExportFileByte
    {


        public string ContentType { get; set; }

        /// <summary>
        /// Nombre del archivo y debe contener la extensión del archivo.
        /// <para>Ejemplo: documento.pdf</para>
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Archivo expresado en arreglo de bytes
        /// </summary>
        public byte[] FileBytes { get; set; }

    }


}
