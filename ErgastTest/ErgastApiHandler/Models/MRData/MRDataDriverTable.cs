using ErgastApiHandler.Models.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.MRData
{
    public class MRDataDriverTable
    {
        [JsonProperty("DriverTable")]
        public DriverTable DriverTable { get; set; }
    }
}
