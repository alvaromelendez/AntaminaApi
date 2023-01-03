using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class ModelNotificeClassMaster
    {
        [JsonPropertyName("Key")]
        public string Key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
    public class ModelPlanificationGroupMaster
    {
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Center")]
        public string Center { get; set; }
    }
    public class ModelJobPositionMaster
    {
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Manager")]
        public string Manager { get; set; }

        [JsonPropertyName("Center")]
        public int Center { get; set; }

        [JsonPropertyName("PlanificationGroup")]
        public string PlanificationGroup { get; set; }
    }
    public class ModelPriorityMaster
    {
        [JsonPropertyName("Key")]
        public string Key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
    public class ModelFaultMaster
    {
        [JsonPropertyName("ObjectPart")]
        public string ObjectPart { get; set; }

        [JsonPropertyName("key")]
        public int key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
    public class ModelSymptomFaultMaster
    {
        [JsonPropertyName("SymptomFault")]
        public string SymptomFault { get; set; }

        [JsonPropertyName("Key")]
        public string Key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
    public class ModelCauseMaster
    {
        [JsonPropertyName("Cause")]
        public string Cause { get; set; }

        [JsonPropertyName("Key")]
        public int Key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }

    public class ModelActivityMaster
    {
        [JsonPropertyName("Activity")]
        public string Activity { get; set; }

        [JsonPropertyName("Key")]
        public int Key { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}
