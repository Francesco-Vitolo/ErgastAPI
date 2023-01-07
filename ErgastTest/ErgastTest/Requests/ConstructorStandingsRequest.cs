using ErgastTest.Interfaces;
using ErgastTest.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Requests
{
    public class ConstructorStandingsRequest : TRequest
    {
        public ConstructorStandingsRequest(int year, int round = 0) : base(year, round)
        {
            Url += "/constructorStandings.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ConstructorStandingsResponse>(json);
        }
    }
}
