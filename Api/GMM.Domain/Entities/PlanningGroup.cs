using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class PlanningGroup : IGenerateEntity<PlanningGroup>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Center { get; set; }

        public PlanningGroup RecoverKey()
        {
            return new PlanningGroup() { Id = this.Id };
        }
    }
}
