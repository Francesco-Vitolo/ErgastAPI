using ErgastApiHandler.Models.MRData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Responses
{
    public class RaceTableResponse : TResponse
    {
        [JsonProperty("MRData")]
        public MRDataRaceTable MRData { get; set; }

        public bool IsValid()
        {
            return MRData.RaceTable.Races.Count != 0;
        }

        public override string ToString()
        {
            string res = "";
            foreach(var race in MRData.RaceTable.Races)
            {
                res +=  "\n" + race.ToString();
            }
            return res;
            
        }
    }
}
