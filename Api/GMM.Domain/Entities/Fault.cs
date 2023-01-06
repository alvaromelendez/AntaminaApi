namespace GMM.Domain.Entities
{
    public class Fault : IGenerateEntity<Fault>
    {
        public int Id { get; set; }
        public string ObjectPart { get; set; }
        public int Key { get; set; }
        public string Description { get; set; }
        public Fault RecoverKey()
        {
            return new Fault() { Id = this.Id };
        }
    }
}
