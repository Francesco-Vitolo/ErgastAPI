using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class QualifyingRequest : TRequest
    {
        public QualifyingRequest(int year, int round = 0) : base(year, round)
        {
            Url += "/qualifying.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ResultsResponse>(json);
        }
    }
}
