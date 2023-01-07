using ErgastTest.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Interfaces
{
    public interface IDeserializeResponse
    {
        public TResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ConstructorStandingsResponse>(json);
        }
    }
}
