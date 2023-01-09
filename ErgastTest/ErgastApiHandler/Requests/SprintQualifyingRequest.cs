using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class SprintQualifyingRequest : TRequest
    {
        public SprintQualifyingRequest(int year, int round = 0) : base(year, round)
        {
            Url += "/sprint.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ResultsResponse>(json);
        }
    }
}
