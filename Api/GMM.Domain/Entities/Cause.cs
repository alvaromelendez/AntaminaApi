namespace GMM.Domain.Entities
{
    public class Cause : IGenerateEntity<Cause>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Key { get; set; }
        public string Description { get; set; }
        public Cause RecoverKey()
        {
            return new Cause() { Id = this.Id };
        }
    }
}
