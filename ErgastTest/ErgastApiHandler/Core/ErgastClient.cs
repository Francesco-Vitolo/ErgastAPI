using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ErgastApiHandler.Models.Common;
using ErgastApiHandler.Models.MRData;
using ErgastApiHandler.Responses;
using ErgastApiHandler.Requests;

namespace ErgastApiHandler.Core
{
    public class ErgastClient : IErgastClient
    {
        private const string URL = Constants.BASE_URL;
        private readonly HttpClient client;

        public ErgastClient()
        {
            client = new HttpClient();
        }

        public async Task<TResponse?> GetAsyncGeneric(TRequest request)
        {
            using (HttpResponseMessage response = await client.GetAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();                    
                    TResponse responseObj = request.Deserialize(standings);
                    return responseObj.IsValid() ? responseObj : null;                   
                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }
        }


        public async Task<ConstructorStandingsList> GetConstructorStandingsAsync(int year, int round)
        {
            string url = $"{URL}/{year}/{round}/constructorStandings.json";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();
                    ConstructorStandingsResponse responseObj = JsonConvert.DeserializeObject<ConstructorStandingsResponse>(standings);
                    return responseObj.MRData.StandingsTable.StandingsLists[0];

                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }
        }
       
        public async Task<DriverStandingsList> GetDriverStandingsAsync(int year, int round)
        {
            string url = $"{URL}/{year}/driverStandings.json";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string? standings = response.Content.ReadAsStringAsync().Result;
                DriverStandingsResponse rootObj = JsonConvert.DeserializeObject<DriverStandingsResponse>(standings);
                return rootObj.MRData.StandingsTable.StandingsLists[0];
            }
            else
            {
                throw new Exception("Error retrieving driver standings");
            }
        }

        public async Task<Race> GetSeasonResultsAsync(int year, int round)
        {
            string url = $"{URL}/{year}/results.json";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();
                    ResultsResponse responseObj = JsonConvert.DeserializeObject<ResultsResponse>(standings);
                    return responseObj.MRData.RaceTable.Races[0];
                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }

        }
    }
}