using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class DriverStanding
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("Driver")]
        public Driver Driver { get; set; }

        [JsonProperty("points")]
        public string Points { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        public override string ToString()
        {
            return $"\n{Position} {Driver}: {Points} points ({Wins} wins)";
        }
    }
}
