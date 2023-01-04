//using System.Text.Json.Serialization;

using Newtonsoft.Json;

namespace GMM.Application.Models
{
    public class Equipment
    {
        public IEnumerable<ModelEquipment> Equipments { get; set; }

    }
    public class ModelEquipment
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
