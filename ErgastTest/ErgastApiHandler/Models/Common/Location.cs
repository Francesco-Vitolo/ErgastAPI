using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class Location
    {
        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Locality}, {Country}";
        }
    }
}
