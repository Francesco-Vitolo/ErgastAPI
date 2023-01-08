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
        IErgastClient client = new ErgastClient();

        [TestMethod]
        public void GetAsyncGeneric_ConstructorStandingsRequest()
        {
            TResponse? response = client.GetAsyncGeneric(new ConstructorStandingsRequest(2021, 5)).Result;
            Assert.IsTrue(response.ToString().Contains("Mercedes"));
        }

        [TestMethod]
        public void GetAsyncGeneric_IsNotValidResponse()
        {
            TResponse? response = client.GetAsyncGeneric(new ConstructorStandingsRequest(2025)).Result;
            Assert.IsNull(response);
        }


        [TestMethod]
        public void GetAsyncGeneric_SeasonResultsRequest()
        {
            TResponse? response = client.GetAsyncGeneric(new SeasonResultsRequest(2021, 5)).Result;
            Assert.IsTrue(response.ToString().ToLower().Contains("ham"));
        }

        [TestMethod]
        public void GetAsyncGeneric_DriverResultsRequest()
        {
            TResponse? response = client.GetAsyncGeneric(new DriverStandingsRequest(2004)).Result;
            Assert.IsTrue(response.ToString().ToLower().Contains("msc"));
        }

        [TestMethod]
        public void GetAsyncGeneric_QualifyinfResults()
        {
            TResponse? response = client.GetAsyncGeneric(new QualifyingRequest(2021, 4)).Result;
            Assert.IsTrue(response.ToString().ToLower().Contains("q1"));
        }

        [TestMethod]
        public void GetConstructorStandings()
        {
            ConstructorStandingsList result = client.GetConstructorStandingsAsync(2021, 0).Result;
            Assert.IsNotNull(result.ConstructorStandings.FirstOrDefault(x => x.Constructor.Name.ToLower() == "mercedes"));
        }
        [TestMethod]
        public void GetDriverStandings()
        {
            DriverStandingsList result = client.GetDriverStandingsAsync(2021, 0).Result;
            Assert.IsNotNull(result.DriverStandings.FirstOrDefault(x => x.Driver.PermanentNumber == 33));
        }       
    }
}