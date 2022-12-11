using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class ModelProccess
    {
        public int IdProccess { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnable { get; set; }
        public List<ModelProccessConfiguration> ProccessConfigurations { get; set; }
        public ModelProccess()
        {
            ProccessConfigurations = new List<ModelProccessConfiguration>();
        }
    }
}
