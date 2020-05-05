using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;
namespace Stet
{
   class  Resp2
    {
        public string Country { get; set; }
        public string[] Subregions { get; set; }
    }

}
