﻿using ErgastTest.Models.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgastTest.Models.MRData
{
    public class MRDataConstructorStandingsTable
    {
        [JsonProperty("StandingsTable")]
        public ConstructorStandingsTable StandingsTable { get; set; }
    }
}
