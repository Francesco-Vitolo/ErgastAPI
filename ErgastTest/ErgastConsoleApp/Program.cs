using System;
using System.Net.Http;
using System.Threading.Tasks;
using ErgastApiHandler.Core;
using ErgastApiHandler.Models.Common;
using ErgastApiHandler.Requests;
using ErgastApiHandler.Responses;

namespace ErgastConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            ErgastClient client = new ErgastClient();

            ResultsResponse response1 = client.GetAsyncGeneric<ResultsResponse>(new RaceResultRequest(2021,5)).Result;
            Console.WriteLine(response1.Values.RaceName);
            var response = client.GetAsyncGeneric<RaceTableResponse>(new DriverRequest(2021, "alonso", 2)).Result;


            var response2 = client.GetAsyncGeneric<ResultsResponse>(new QualifyingResultRequest(2030, 2)).Result;
            //AllDriversResponse response2 = client.GetAsyncGeneric<AllDriversResponse>(new AllDriversRequest(2021,5)).Result;
            //Console.WriteLine(response2);
            //TResponse? response6 = client.GetAsyncGeneric(new ConstructorRequest(2021, "mercedes")).Result;
            ///onstructorStandingsResponse constructorStandings = client.GetConstructorStandingsAsync(2020, 5).Result;
            //constructorStandings.GetValues();


        }
    }
}