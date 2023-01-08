using ErgastApiHandler.Models.MRData;
using ErgastApiHandler.Models.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Responses
{
    public class ResultsResponse : TResponse
    {
        [JsonProperty("MRData")]
        public MRDataRaceTable MRData { get; set; }

        public bool IsValid()
        {
            return MRData.RaceTable.Races.Count != 0;
        }

        public override string ToString()
        {
            return MRData.RaceTable.Races[0].ToString();
        }
    }
}
