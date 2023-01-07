using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Models.Common
{
    public class RaceResult
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("Driver")]
        public Driver Driver { get; set; }

        [JsonProperty("Constructor")]
        public Constructor Constructor { get; set; }

        public override string ToString()
        {
            return $"\n{Position}: {Driver} ({Constructor})";
        }
    }
}
