using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class DriverRequest : TRequest
    {
        public DriverRequest(string name, int limit, int offset) : base()
        {
            Url += $"/drivers/{name}/results.json?limit={limit}&offset={offset}";
        }

        public DriverRequest(int year, string name, int round = 0) : base(year, round)
        {
            Url += $"/drivers/{name}/results.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<RaceTableResponse>(json);
        }
    }
}
