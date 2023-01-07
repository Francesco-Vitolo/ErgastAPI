using ErgastTest.Models.MRData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Responses
{
    public class DriverStandingsResponse : TResponse
    {
        [JsonProperty("MRData")]
        public MRDataDriverStandingsTable MRData { get; set; }

        public override string ToString()
        {
            return MRData.StandingsTable.StandingsLists[0].ToString();
        }
    }
}
