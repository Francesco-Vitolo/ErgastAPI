using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class AllConstructorsRequest : TRequest
    {
        public AllConstructorsRequest(int limit, int offset) : base()
        {
            Url += $"/constructors.json?limit={limit}&offset={offset}";
        }      

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<AllConstructorsResponse>(json);
        }
    }
}
