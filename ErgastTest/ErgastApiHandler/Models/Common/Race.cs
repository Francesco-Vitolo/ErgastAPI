using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class Race
    {
        [JsonProperty("raceName")]
        public string RaceName { get; set; }

        [JsonProperty("Circuit")]
        public Circuit Circuit { get; set; }

        [JsonProperty("Results")]
        public List<RaceResult>? Results { get; set; }

        [JsonProperty("QualifyingResults")]
        private List<RaceResult>? QualifyingResults { set { Results = value; } }

        [JsonProperty("SprintResults")]
        private List<RaceResult>? SprintResults { set { Results = value; } }

        public override string ToString()
        {
            string raceInfos = $"\n{RaceName} - {Circuit}:";
            if (Results is not null)
            {
                foreach (RaceResult result in Results)
                {
                    raceInfos += result;
                }
            }           
            return raceInfos;
        }
    }

}
