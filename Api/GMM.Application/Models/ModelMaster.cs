using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class ModelNotificeClass
    {
        [JsonPropertyName("KEY")]
        public string KEY { get; set; }

        [JsonPropertyName("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
    }
    public class ModelPlanificationGroup
    {
        [JsonPropertyName("CODIGO")]
        public string CODIGO { get; set; }

        [JsonPropertyName("DESCRIPCION")]
        public string DESCRIPCION { get; set; }

        [JsonPropertyName("CENTRO")]
        public string CENTRO { get; set; }
    }
    public class ModelJobPosition
    {
        [JsonPropertyName("CODIGO")]
        public string CODIGO { get; set; }

        [JsonPropertyName("DESCRIPCION")]
        public string DESCRIPCION { get; set; }

        [JsonPropertyName("RESPONSABLE")]
        public string RESPONSABLE { get; set; }

        [JsonPropertyName("CENTRO")]
        public int CENTRO { get; set; }

        [JsonPropertyName("GRUPOPLANIFICACION")]
        public string GRUPOPLANIFICACION { get; set; }
    }
    public class ModelPriority
    {
        [JsonPropertyName("KEY")]
        public string KEY { get; set; }

        [JsonPropertyName("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
    }
    public class ModelFaultt
    {
        [JsonPropertyName("Parte Objeto")]
        public string ParteObjeto { get; set; }

        [JsonPropertyName("key")]
        public int key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
    public class ModelCausaa
    {
        [JsonPropertyName("Causa")]
        public string Causa { get; set; }

        [JsonPropertyName("Key")]
        public int Key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }

    public class ModelActivityy
    {
        [JsonPropertyName("Actividad")]
        public string Actividad { get; set; }

        [JsonPropertyName("Key")]
        public int Key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

    }

}
