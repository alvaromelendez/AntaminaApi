using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Models
{
    public class ModelToken
    {
        [JsonProperty("x-csrf-token")]
        public string Token { get; set; }
    }
}
