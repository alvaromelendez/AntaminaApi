namespace GMM.Domain.Entities
{
    public class Document : IGenerateEntity<Document>
    {
        public Guid IdDocument { get; set; }
        public Document RecoverKey()
        {
            return new Document() { IdDocument = this.IdDocument };
        }
    }
}
