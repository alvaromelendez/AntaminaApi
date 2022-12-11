namespace GMM.Domain.Entities
{
    public class Fault : IGenerateEntity<Fault>
    {
        public Guid IdFault { get; set; }
        public DateTime StartDate { get; set; }
        public string StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public string EndTime { get; set; }
        public bool Stop { get; set; }
        public string StopDuration { get; set; }        
        public Fault RecoverKey()
        {
            return new Fault() { IdFault = this.IdFault };
        }
    }
}
