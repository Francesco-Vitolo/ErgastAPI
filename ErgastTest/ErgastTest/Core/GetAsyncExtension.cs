using ErgastTest.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Core
{
    static class GetAsyncExtension
    {
        public static Task<HttpResponseMessage> GetAsync(this HttpClient client, TRequest request)
        {
            return client.GetAsync(request.ToString());
        }
    }
}
