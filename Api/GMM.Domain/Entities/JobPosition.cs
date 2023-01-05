using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class JobPosition : IGenerateEntity<JobPosition>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Responsible { get; set; }
        public int Center { get; set; }
        public string PlanificationGroup { get; set; }
        public JobPosition RecoverKey()
        {
            return new JobPosition() { Id = this.Id };
        }
    }
}
