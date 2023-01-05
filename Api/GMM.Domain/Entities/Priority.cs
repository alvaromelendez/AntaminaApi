using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class Priority : IGenerateEntity<Priority>
    {
        public int Id { get; set; }
        public int Key { get; set; }
        public string Description { get; set; }
        public Priority RecoverKey()
        {
            return new Priority() { Id = this.Id };
        }
    }
}
