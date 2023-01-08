using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class SeasonResultsRequest : TRequest
    {
        public SeasonResultsRequest(int year, int round = 0) : base(year, round)
        {
            Url += "/results.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<SeasonResultsResponse>(json);
        }
    }
}
