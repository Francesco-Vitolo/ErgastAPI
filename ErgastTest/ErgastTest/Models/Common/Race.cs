using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Models.Common
{
    public class Race
    {
        [JsonProperty("raceName")]
        public string RaceName { get; set; }

        [JsonProperty("Circuit")]
        public Circuit Circuit { get; set; }

        [JsonProperty("Results")]
        public List<RaceResult> Results { get; set; }

        public override string ToString()
        {
            string raceInfos = $"{RaceName} - {Circuit}:";
            foreach (RaceResult result  in Results)
            {
                raceInfos += result;
            }
            return raceInfos;
        }
    }

}
