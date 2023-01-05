namespace GMM.Domain.Entities
{
    public class NotificationClass : IGenerateEntity<NotificationClass>
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }

        public NotificationClass RecoverKey()
        {
            return new NotificationClass() { Id = this.Id };
        }
    }
}
