using System;
using System.Net.Http;
using System.Threading.Tasks;
using ErgastTest.Core;
using ErgastTest.Models.Common;
using ErgastTest.Requests;
using ErgastTest.Responses;

namespace ErgastConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            ErgastClient client = new ErgastClient();

            TResponse? response = client.GetAsyncGeneric(new SeasonResultsRequest(2021, 5)).Result;
            TResponse? response2 = client.GetAsyncGeneric(new SeasonResultsRequest(2021)).Result;

            TResponse? response3 = client.GetAsyncGeneric(new ConstructorStandingsRequest(2021, 5)).Result;
            TResponse? response4 = client.GetAsyncGeneric(new ConstructorStandingsRequest(2021)).Result;

            TResponse? response5 = client.GetAsyncGeneric(new DriverStandingsRequest(2022, 6)).Result;
            TResponse? response6 = client.GetAsyncGeneric(new DriverStandingsRequest(2004)).Result;
            Console.WriteLine(response6);
        }
    }
}