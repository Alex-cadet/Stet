using System;
using System.Collections.Generic;
using System.Text;

namespace Stet
{
    class Response
    {
        public string Updated { get; set; }
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
        public string AffectedCountries { get; set; }
    }
}
