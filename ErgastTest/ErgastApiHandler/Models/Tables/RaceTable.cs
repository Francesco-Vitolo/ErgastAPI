using ErgastApiHandler.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Tables
{
    public class RaceTable
    {
        [JsonProperty("Races")]
        public List<Race> Races { get; set; }
    }
}
