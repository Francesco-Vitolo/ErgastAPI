using ErgastApiHandler.Core;
using ErgastApiHandler.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Requests
{
    public abstract class TRequest
    {
        public string Url { get; set; }
        protected TRequest()
        {
            Url = $"{Constants.BASE_URL}";           
        }
        protected TRequest(int year, int round = 0)
        {
            Url = round <= 0
                ? Url = $"{Constants.BASE_URL}/{year}"
                : Url = $"{Constants.BASE_URL}/{year}/{round}";
        }

        public virtual TResponse Deserialize(string json)
        {
            return null;
        }
        public override string ToString()
        {
            return Url;
        }
    }
}
