using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class SymptomFault : IGenerateEntity<SymptomFault>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public SymptomFault RecoverKey()
        {
            return new SymptomFault() { Id = this.Id };
        }
    }
}
