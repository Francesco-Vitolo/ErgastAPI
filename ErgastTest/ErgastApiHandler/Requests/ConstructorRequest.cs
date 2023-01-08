using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class ConstructorRequest : TRequest
    {
        public ConstructorRequest(int year, string name, int round = 0) : base(year, round)
        {
            Url += $"/constructors/{name}/results.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ConstructorResponse>(json);
        }
    }
}
