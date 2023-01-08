using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public class DriverStandingsRequest : TRequest
    {
        public DriverStandingsRequest(int year, int round = 0) : base(year, round)
        {
            Url += "/driverStandings.json";
        }

        public override TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<DriverStandingsResponse>(json);
        }
    }
}
