using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;
namespace Stet
{
     class  Resp1
   {

        public string Updated { get; set; }
        public string Country { get; set; }
        public Ident CountryInfo { get; set; }
        public string Cases { get; set; }
        public string TodayCases { get; set; }
        public string Deaths { get; set; }
        public string TodayDeaths { get; set; }
        public string Recovered { get; set; }
        public string Active { get; set; }
        public string Critical { get; set; }
        public string CasesPerOneMillion { get; set; }
        public string DeathsPerOneMillion { get; set; }
        public string Tests { get; set; }
        public string TestsPerOneMillion { get; set; }
        public string Continent { get; set; }
    }
    class Ident
    {

        public string _id { get; set; }
        public string Iso2 { get; set; }
        public string Iso3 { get; set; }        
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Flag { get; set; }

    }
}
