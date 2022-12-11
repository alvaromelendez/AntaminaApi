using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Domain.Entities
{
    public class Position : IGenerateEntity<Position>
    {
        public Guid IdPosition { get; set; }
        public string ObjectPart { get; set; }
        public string FaultSymptom { get; set; }
        public string Text { get; set; }
        public string Cause { get; set; }
        public string CauseText { get; set; }
        public Position RecoverKey()
        {
            return new Position() { IdPosition = this.IdPosition };
        }
    }
}
