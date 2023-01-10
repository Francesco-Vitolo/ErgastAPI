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

            TResponse? response1 = client.GetAsyncGeneric(new RaceResultRequest(2021,5)).Result;
            TResponse? response2 = client.GetAsyncGeneric(new QualifyingRequest(2021, 4)).Result;
            TResponse? response3 = client.GetAsyncGeneric(new SprintQualifyingRequest(2021)).Result;

            TResponse? response4 = client.GetAsyncGeneric(new DriverRequest(2021,"alonso")).Result;
            TResponse? response5 = client.GetAsyncGeneric(new DriverStandingsRequest(2022, 6)).Result;
            Console.WriteLine(response5);
            TResponse? response6 = client.GetAsyncGeneric(new ConstructorRequest(2025, "mercedes")).Result;
            TResponse? response7 = client.GetAsyncGeneric(new ConstructorStandingsRequest(2021, 5)).Result;

            TResponse? response8 = client.GetAsyncGeneric(new DriverRequest("alonso",100,0)).Result;
            TResponse? response9 = client.GetAsyncGeneric(new ConstructorRequest("ferrari",100,0)).Result;
            //TResponse? response10 = client.GetAsyncGeneric(new ConstructorRequest(100,0)).Result;
            TResponse? response11 = client.GetAsyncGeneric(new AllDriversRequest(50,0)).Result;
            TResponse? response12 = client.GetAsyncGeneric(new AllConstructorsRequest(50,0)).Result;
            Console.WriteLine(response12);


        }
    }
}