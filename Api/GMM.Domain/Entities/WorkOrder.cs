namespace GMM.Domain.Entities
{
    public class WorkOrder : IGenerateEntity<WorkOrder>
    {
        public Guid IdWorkOrder { get; set; }
        public WorkOrder RecoverKey()
        {
            return new WorkOrder() { IdWorkOrder = this.IdWorkOrder };
        }
    }
}
