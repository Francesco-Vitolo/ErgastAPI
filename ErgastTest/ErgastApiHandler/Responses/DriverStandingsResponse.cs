using ErgastApiHandler.Models.Common;
using ErgastApiHandler.Models.MRData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Responses
{
    public class DriverStandingsResponse : TResponse
    {
        [JsonProperty("MRData")]
        public MRDataDriverStandingsTable MRData { get; set; }

        public DriverStandingsList Values => MRData.StandingsTable.StandingsLists[0];

        public bool IsValid()
        {
            return MRData.StandingsTable.StandingsLists.Count != 0;
        }

        public override string ToString()
        {
            return MRData.StandingsTable.StandingsLists[0].ToString();
        }
    }
}
