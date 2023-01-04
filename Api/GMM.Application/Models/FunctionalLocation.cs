using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class FunctionalLocation
    {
        public IEnumerable<ModelFunctionalLocation> FunctionalLocations { get; set; }
    }
    public class ModelFunctionalLocation
    {
        [JsonPropertyName("EQUNR_TPLNR")]
        public string EQUNRTPLNR { get; set; }

        [JsonPropertyName("EQUNR_TPLNR_INT")]
        public string EQUNRTPLNRINT { get; set; }

        [JsonPropertyName("EQFNR")]
        public string EQFNR { get; set; }

        [JsonPropertyName("EQKTX")]
        public string EQKTX { get; set; }

        [JsonPropertyName("AUFNR")]
        public string AUFNR { get; set; }

        [JsonPropertyName("OBJTYP")]
        public string OBJTYP { get; set; }

        [JsonPropertyName("DOBJTYP")]
        public string DOBJTYP { get; set; }

        [JsonPropertyName("ID_OBJ")]
        public string IDOBJ { get; set; }
    }


}
