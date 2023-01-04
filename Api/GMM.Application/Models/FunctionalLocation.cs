using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class FunctionalLocation
    {
        public IEnumerable<ModelFunctionalLocation> FunctionalLocations { get; set; }
    }
    public class ModelFunctionalLocation
    {
        [JsonProperty("EQUNR_TPLNR")]
        public string EQUNRTPLNR { get; set; }

        [JsonProperty("EQUNR_TPLNR_INT")]
        public string EQUNRTPLNRINT { get; set; }

        [JsonProperty("EQFNR")]
        public string EQFNR { get; set; }

        [JsonProperty("EQKTX")]
        public string EQKTX { get; set; }

        [JsonProperty("AUFNR")]
        public string AUFNR { get; set; }

        [JsonProperty("OBJTYP")]
        public string OBJTYP { get; set; }

        [JsonProperty("DOBJTYP")]
        public string DOBJTYP { get; set; }

        [JsonProperty("ID_OBJ")]
        public string IDOBJ { get; set; }
    }


}
