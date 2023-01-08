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

            //TResponse? response = client.GetAsyncGeneric(new SeasonResultsRequest(2021, 5)).Result;
            //Console.WriteLine(response);
            //TResponse? response2 = client.GetAsyncGeneric(new SeasonResultsRequest(2024)).Result;
            //TResponse? response3 = client.GetAsyncGeneric(new DriverRequest(2021,"alonso")).Result;
            //Console.WriteLine(response3);

            //TResponse? response4 = client.GetAsyncGeneric(new ConstructorRequest(2025, "mercedes")).Result;
            //Console.WriteLine(response4);
            //TResponse? response3 = client.GetAsyncGeneric(new ConstructorStandingsRequest(2021, 5)).Result;
            TResponse? response4 = client.GetAsyncGeneric(new ConstructorStandingsRequest(2021)).Result;

            //TResponse? response5 = client.GetAsyncGeneric(new DriverStandingsRequest(2022, 6)).Result;
            TResponse? response6 = client.GetAsyncGeneric(new DriverStandingsRequest(2014)).Result;

            TResponse? response7 = client.GetAsyncGeneric(new QualifyingRequest(2021,4)).Result;
            Console.WriteLine(response4);
        }
    }
}