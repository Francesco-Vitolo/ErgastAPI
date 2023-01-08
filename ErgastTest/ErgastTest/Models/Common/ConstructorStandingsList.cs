using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class ConstructorStandingsList
    {
        [JsonProperty("ConstructorStandings")]
        public List<ConstructorStanding> ConstructorStandings { get; set; }

        public override string ToString()
        {
            string result = "";
            foreach (ConstructorStanding standing in ConstructorStandings)
            {
                result += standing;
            }
            return result;
        }
    }
}
