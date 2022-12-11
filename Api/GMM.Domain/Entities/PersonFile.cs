using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class PersonFile : IGenerateEntity<PersonFile>
    {
        public Guid IdPerson { get; set; }
        public Guid IdAttachedFile { get; set; }

        public PersonFile RecoverKey()
        {
            return new PersonFile() { IdAttachedFile = this.IdAttachedFile, IdPerson = this.IdPerson };
        }
    }

}
