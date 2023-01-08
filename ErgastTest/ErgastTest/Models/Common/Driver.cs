using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastApiHandler.Models.Common
{
    public class Driver
    {
        [JsonProperty("driverId")]
        public string DriverId { get; set; }

        [JsonProperty("permanentNumber")]
        public int PermanentNumber { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        public override string ToString()
        {
            return $"{PermanentNumber} {Code}";
        }
    }
}
