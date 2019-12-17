using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TriBeforeYouBuy.Models
{
    public class Triangle
    {
        [JsonProperty("v1")]
        public Point V1 { get; set; }

        [JsonProperty("v2")]
        public Point V2 { get; set; }

        [JsonProperty("v3")]
        public Point V3 { get; set; }
    }
}
