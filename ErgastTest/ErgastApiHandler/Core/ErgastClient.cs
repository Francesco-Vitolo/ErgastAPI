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
        private readonly HttpClient client;

        public ErgastClient()
        {
            client = new HttpClient();
        }

        public async Task<T> GetAsyncGeneric<T>(TRequest request) where T : TResponse
        {
            try
            {
                using (HttpResponseMessage response = await client.GetAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string? standings = await response.Content.ReadAsStringAsync();
                        T responseObj = (T)request.Deserialize(standings);
                        return responseObj;
                    }
                    else
                    {
                        throw new Exception($"Error retrieving data ({response.ReasonPhrase})");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return default(T);
        }


        public async Task<ConstructorStandingsResponse> GetConstructorStandingsAsync(int year, int round)
        {
            string url = $"{Constants.BASE_URL}/{year}/{round}/constructorStandings.json";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();
                    ConstructorStandingsResponse responseObj = JsonConvert.DeserializeObject<ConstructorStandingsResponse>(standings);
                    return responseObj;
                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }
        }

        public async Task<DriverStandingsResponse> GetDriverStandingsAsync(int year, int round)
        {
            string url = $"{Constants.BASE_URL}/{year}/driverStandings.json";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string? standings = response.Content.ReadAsStringAsync().Result;
                DriverStandingsResponse responseObj = JsonConvert.DeserializeObject<DriverStandingsResponse>(standings);
                return responseObj;
            }
            else
            {
                throw new Exception("Error retrieving driver standings");
            }
        }

        public async Task<ResultsResponse> GetSeasonResultsAsync(int year, int round)
        {
            string url = $"{Constants.BASE_URL}/{year}/results.json";
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string? standings = await response.Content.ReadAsStringAsync();
                    ResultsResponse responseObj = JsonConvert.DeserializeObject<ResultsResponse>(standings);
                    return responseObj;
                }
                else
                {
                    throw new Exception($"Error retrieving constructor standings ({response.ReasonPhrase})");
                }
            }

        }
    }
}