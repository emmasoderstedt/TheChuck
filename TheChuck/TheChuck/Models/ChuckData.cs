using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TheChuck.Models
{
    public class ChuckData
    {
        [JsonProperty("value")]
        public string Joke { get; set; }

        [JsonProperty("categories")]
        public List<object> Categories { get; set; }
    }
}
