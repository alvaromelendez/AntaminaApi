using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class ModelNotificeClassMaster
    {
        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
    public class ModelPlanificationGroupMaster
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Center")]
        public string Center { get; set; }
    }
    public class ModelJobPositionMaster
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Manager")]
        public string Manager { get; set; }

        [JsonProperty("Center")]
        public int Center { get; set; }

        [JsonProperty("PlanificationGroup")]
        public string PlanificationGroup { get; set; }
    }
    public class ModelPriorityMaster
    {
        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
    public class ModelFaultMaster
    {
        [JsonProperty("ObjectPart")]
        public string ObjectPart { get; set; }

        [JsonProperty("key")]
        public int key { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
    public class ModelSymptomFaultMaster
    {
        [JsonProperty("SymptomFault")]
        public string SymptomFault { get; set; }

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
    public class ModelCauseMaster
    {
        [JsonProperty("Cause")]
        public string Cause { get; set; }

        [JsonProperty("Key")]
        public int Key { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class ModelActivityMaster
    {
        [JsonProperty("Activity")]
        public string Activity { get; set; }

        [JsonProperty("Key")]
        public int Key { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }
}
