using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class RaceResult
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("Driver")]
        public Driver Driver { get; set; }

        [JsonProperty("Constructor")]
        public Constructor Constructor { get; set; }

        [JsonProperty("Q1")]
        public string? Q1 { get; set; }

        [JsonProperty("Q2")]
        public string? Q2 { get; set; }

        [JsonProperty("Q3")]
        public string? Q3 { get; set; }

        public override string ToString()
        {
            string res = $"\n{Position}: {Driver} ({Constructor})\n";
            if (Q1 is not null)
                res += $"Q1: {Q1}\n";
            if (Q2 is not null)
                res += $"Q2: {Q2}\n";
            if (Q3 is not null)
                res += $"Q3: {Q3}\n";            
            return res;
        }
    }
}
