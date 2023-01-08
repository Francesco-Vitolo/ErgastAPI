using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class DriverStandingsList
    {
        [JsonProperty("DriverStandings")]
        public List<DriverStanding> DriverStandings { get; set; }

        public override string ToString()
        {
            string result = "";
            foreach (DriverStanding standing in DriverStandings)
            {
                result += standing;
            }
            return result;
        }
    }
}
