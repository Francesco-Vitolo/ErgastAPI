using System;
using System.Net.Http;
using System.Threading.Tasks;
using ErgastTest.Core;
using ErgastTest.Models.Common;
using ErgastTest.Requests;
using ErgastTest.Responses;

namespace ConsoleApp1
{
    public class Program
    {
        private const string BASE_URL = "http://ergast.com/api/f1";
        public static void Main()
        {
            Moin();
        }

        public static void Moin()
        {
            ErgastAPIHandler handler = new ErgastAPIHandler();
            //StandingsList? result = handler.GetConstructorStandings(2021,0).Result;
            //Race? results = handler.GetSeasonResultsAsync(2021).Result;
            //Console.WriteLine(results);
            TResponse? response = handler.GetSeasonResultsAsyncGeneric(new SeasonResultsRequest(2021,5)).Result;
            TResponse? response2 = handler.GetSeasonResultsAsyncGeneric(new SeasonResultsRequest(2021)).Result;

            TResponse? response3 = handler.GetSeasonResultsAsyncGeneric(new ConstructorStandingsRequest(2021, 5)).Result;
            TResponse? response4 = handler.GetSeasonResultsAsyncGeneric(new ConstructorStandingsRequest(2021)).Result;
            Console.WriteLine(response4);
        }
    }
}