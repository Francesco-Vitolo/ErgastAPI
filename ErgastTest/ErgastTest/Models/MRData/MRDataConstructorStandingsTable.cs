using ErgastApiHandler.Models.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.MRData
{
    public class MRDataConstructorStandingsTable
    {
        [JsonProperty("StandingsTable")]
        public ConstructorStandingsTable StandingsTable { get; set; }
    }
}
