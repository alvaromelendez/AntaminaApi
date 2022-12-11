using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class UploadFile : IGenerateEntity<UploadFile>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public DateTime RegistryDate { get; set; }

        public UploadFile RecoverKey()
        {
            return new UploadFile() { Id = this.Id };
        }
    }
}
