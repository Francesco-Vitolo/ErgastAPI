using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ErgastTest.Models.Common;
using ErgastTest.Models.MRData;
using ErgastTest.Responses;
using ErgastTest.Requests;

namespace ErgastTest.Core
{
    public class ErgastAPIHandler
    {
        private const string BASE_URL = "http://ergast.com/api/f1";
        private readonly HttpClient client;

        public ErgastAPIHandler()
        {
            client = new HttpClient();
        }

        public async Task<StandingsList> GetConstructorStandings(int year, int round) //optional machen
        {
            string url = $"{BASE_URL}/{year}/{round}/constructorStandings.json";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();
                    ConstructorStandingsResponse rootObj = JsonConvert.DeserializeObject<ConstructorStandingsResponse>(standings);
                    return rootObj.MRData.StandingsTable.StandingsLists[0];

                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }
        }

        public async Task<Race> GetSeasonResultsAsync(int year)  //round optional machen
        {
            string url = $"{BASE_URL}/{year}/results.json";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();
                    SeasonResultsResponse rootObj = JsonConvert.DeserializeObject<SeasonResultsResponse>(standings);
                    return rootObj.MRData.RaceTable.Races[0];
                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }

        }

        public async Task<TResponse> GetSeasonResultsAsyncGeneric(TRequest request)
        {
            using (HttpResponseMessage response = await client.GetAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();
                    TResponse responseObj = request.Deserialize(standings);
                    return responseObj;
                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }
        }


        //public async Task<string> GetDriverStandingsAsync(int year)
        //{
        //    string url = $"{BASE_URL}/{year}/driverStandings.json";
        //    HttpResponseMessage response = await client.GetAsync(url);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var v = response.Content.ReadAsStringAsync().Result;
        //        //var vv = JsonConvert.DeserializeObject(v);
        //        return v;

        //    }
        //    else
        //    {
        //        throw new Exception("Error retrieving driver standings");
        //    }
        //}

    }
}