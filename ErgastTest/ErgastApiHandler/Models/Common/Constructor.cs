using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class Constructor
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
