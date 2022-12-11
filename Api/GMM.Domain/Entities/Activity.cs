namespace GMM.Domain.Entities
{
    public class Activity:IGenerateEntity<Activity>
    {
        public Guid IdActivity { get; set; }
        public string ActivityCodeGroup { get; set; }
        public string ActivityCodeText { get; set; }
        public string ActionText { get; set; }
        public DateTime StartDate { get; set; }
        public string StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public string EndTime { get; set; }
        public Activity RecoverKey()
        {
            return new Activity() { IdActivity = this.IdActivity };
        }
    }
}
