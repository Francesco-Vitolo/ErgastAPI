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
    public class AllConstructorsResponse : TResponse
    {
        [JsonProperty("MRData")]
        public MRDataConstructorTable MRData { get; set; }

        public List<Constructor> Values => MRData.ConstructorTable.Constructors;

        public bool IsValid()
        {
            return MRData.ConstructorTable.Constructors.Count != 0;
        }

        public override string ToString()
        {
            string s = "";
            foreach(var v in MRData.ConstructorTable.Constructors)
            {
                s += v + "\n ";
            }
            return s;
        }
    }
}
