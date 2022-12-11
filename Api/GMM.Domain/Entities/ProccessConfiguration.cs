using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class ProccessConfiguration : IGenerateEntity<ProccessConfiguration>
    {
        public int IdProccessConfiguration { get; set; }
        public int IdProccess { get; set; }
        public string Type { get; set; }
        public Int16? DayOfMonth { get; set; }
        public Int16? DayOfWeek { get; set; }
        public DateTime? DateStart { get; set; }
        public TimeSpan TimeStart { get; set; }
        public string Method { get; set; }
        public string EndPoint { get; set; }
        public string Json_parameters { get; set; }
        public bool Executed { get; set; }
        public bool IsEnable { get; set; }
        public int Try_account { get; set; }
        public ProccessConfiguration RecoverKey()
        {
            return new ProccessConfiguration() { IdProccessConfiguration = this.IdProccessConfiguration };
        }
    }
}
