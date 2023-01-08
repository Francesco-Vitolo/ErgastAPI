using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class Circuit
    {
        [JsonProperty("Location")]
        public Location Location { get; set; }

        public override string ToString()
        {
            return Location.ToString();
        }
    }
}
