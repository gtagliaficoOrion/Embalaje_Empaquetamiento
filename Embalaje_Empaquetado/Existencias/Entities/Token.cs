using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Existencias.Entities
{
    public class Token
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
