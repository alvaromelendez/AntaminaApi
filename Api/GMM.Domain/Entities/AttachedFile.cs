using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace GMM.Domain.Entities
{
    public class AttachedFile : IGenerateEntity<AttachedFile>
    {
        public Guid IdAttachedFile { get; set; }
        public string Name { get; set; }
        public string PathFile { get; set; }
        public string UserRecordCreation { get; set; }
        public DateTime RecordCreationDate { get; set; }
        public string UserEditRecord { get; set; }
        public DateTime? RecordEditDate { get; set; }
        public string RecordStatus { get; set; }


        public AttachedFile RecoverKey()
        {
            return new AttachedFile { IdAttachedFile = this.IdAttachedFile };
        }
    }

}
