using ErgastTest.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Models.Tables
{
    public class DriverStandingsTable
    {
        [JsonProperty("StandingsLists")]
        public List<DriverStandingsList> StandingsLists { get; set; }
    }
}
