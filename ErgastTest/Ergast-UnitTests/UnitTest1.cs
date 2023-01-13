using ErgastApiHandler.Core;
using ErgastApiHandler;
using ErgastApiHandler.Responses;
using ErgastApiHandler.Requests;
using ErgastApiHandler.Models.Common;

namespace Ergast_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        ErgastClient client = new ErgastClient();

        [TestMethod]
        public void GetAsyncGeneric_ConstructorStandingsRequest()
        {
            ConstructorStandingsResponse response = client.GetAsyncGeneric<ConstructorStandingsResponse>(new ConstructorStandingsRequest(2021, 5)).Result;
            Assert.IsTrue(response.Values.ConstructorStandings[0].Constructor is not null);
        }

        [TestMethod]
        public void GetAsyncGeneric_RaceResultRequest()
        {
            var response = client.GetAsyncGeneric<ResultsResponse>(new RaceResultRequest(2021, 5)).Result;
            StringAssert.Contains(response.Values.RaceName.ToLower(), "monaco");
        }

        [TestMethod]
        public void GetAsyncGeneric_DriverResultsRequest()
        {
            var response = client.GetAsyncGeneric<RaceTableResponse>(new DriverRequest("alonso",2021, 2)).Result;
            StringAssert.Equals(response.Values[0].Results[0].Driver.Code.ToLower(), "alo");
        }

        [TestMethod]
        public void GetAsyncGeneric_QualifyingResults()
        {
            var response = client.GetAsyncGeneric<ResultsResponse>(new QualifyingResultRequest(2021, 2)).Result;
            Assert.IsTrue(response.Values.Results[0].Q1 is not null);
        }

        [TestMethod]
        public void GetAsyncGeneric_AllConstructorsRequest()
        {
            var response = client.GetAsyncGeneric<AllConstructorsResponse>(new AllConstructorsRequest(30,30)).Result;
            Assert.IsTrue(response.Values.Count > 10);
        }

        [TestMethod]
        public void GetAsyncGeneric_AllDriversRequest()
        {
            var response = client.GetAsyncGeneric<AllDriversResponse>(new AllDriversRequest(30, 30)).Result;
            Assert.IsTrue(response.Values.Count > 10);
        }
    }
}