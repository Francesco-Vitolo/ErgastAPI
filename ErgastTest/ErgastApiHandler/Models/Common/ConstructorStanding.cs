using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class ConstructorStanding
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("Constructor")]
        public Constructor Constructor { get; set; }

        [JsonProperty("points")]
        public string Points { get; set; }

        public override string ToString()
        {
            return $"\n{Position}. {Constructor}: {Points} points";
        }
    }

}
