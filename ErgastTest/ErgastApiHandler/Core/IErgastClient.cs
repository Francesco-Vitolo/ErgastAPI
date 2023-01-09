using ErgastApiHandler.Models.Common;
using ErgastApiHandler.Requests;
using ErgastApiHandler.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Core
{
    public interface IErgastClient
    {
        public Task<TResponse?> GetAsyncGeneric(TRequest request);
        //public Task<ConstructorStandingsResponse> GetConstructorStandingsAsync(int year, int round);
        //public Task<DriverStandingsResponse> GetDriverStandingsAsync(int year, int round);
        //public Task<Race> GetSeasonResultsAsync(int year, int round);
    }
}
