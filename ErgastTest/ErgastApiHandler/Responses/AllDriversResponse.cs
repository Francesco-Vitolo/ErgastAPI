using ErgastApiHandler.Models.Common;
using ErgastApiHandler.Models.MRData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Responses
{
    public class AllDriversResponse : TResponse
    {
        [JsonProperty("MRData")]
        public MRDataDriverTable MRData { get; set; }

        public List<Driver> Values => MRData.DriverTable.Drivers;

        public bool IsValid()
        {
            return MRData.DriverTable.Drivers.Count != 0;
        }

        public override string ToString()
        {
            string s = "";
            foreach(var v in MRData.DriverTable.Drivers)
            {
                s += v + "\n ";
            }
            return s;
        }
    }
}
