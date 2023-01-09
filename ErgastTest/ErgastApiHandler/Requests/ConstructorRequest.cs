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
        public ConstructorRequest(int limit, int offset) : base()
        {
            Url += $"/constructors.json?limit={limit}&offset={offset}";
        }
        public ConstructorRequest(string name, int limit, int offset) : base()
        {
            Url += $"/constructors/{name}/results.json?limit={limit}&offset={offset}";
        }
        public ConstructorRequest(int year, string name, int round = 0) : base(year, round)
        {
            Url += $"/constructors/{name}/results.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<RaceTableResponse>(json);
        }
    }
}
