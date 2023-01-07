using ErgastTest.Models.MRData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Responses
{
    public class SeasonResultsResponse : TResponse
    {
        [JsonProperty("MRData")]
        public MRDataRaceTable MRData { get; set; }

        public override string ToString()
        {
            return MRData.RaceTable.Races[0].ToString();
        }
    }
}
