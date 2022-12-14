namespace GMM.Domain.Entities
{
    public class Activity: IGenerateEntity<Activity>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Key { get; set; }
        public string Description { get; set; }
        public Activity RecoverKey()
        {
            return new Activity() { Id = this.Id };
        }
    }
}
