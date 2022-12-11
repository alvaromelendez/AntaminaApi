using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class Proccess : IGenerateEntity<Proccess>
    {
        public int IdProccess { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnable { get; set; }
        public Proccess RecoverKey()
        {
            return new Proccess() { IdProccess = this.IdProccess };
        }
    }
}
