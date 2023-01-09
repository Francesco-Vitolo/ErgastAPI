using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class AllDriversRequest : TRequest
    {
        public AllDriversRequest(int limit, int offset) : base()
        {
            Url += $"/drivers.json?limit={limit}&offset={offset}";
        }      

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<AllDriversResponse>(json);
        }
    }
}
