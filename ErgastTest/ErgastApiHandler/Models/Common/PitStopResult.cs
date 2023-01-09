using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class PitStopResult
    {
        public class PitStop
        {
            [JsonProperty("driverId")]
            public string DriverId { get; set; }

            [JsonProperty("lap")]
            public int Lap { get; set; }

            [JsonProperty("stop")]
            public int Stop { get; set; }

            [JsonProperty("time")]
            public string Time { get; set; }

            [JsonProperty("duration")]
            public string Duration { get; set; }

            public override string ToString()
            {
                return $"{DriverId}:\nLap: {Lap}\nStop: {Stop}\nTime: {Time}\nDuration: {Duration}";
            }
        }
    }
}
