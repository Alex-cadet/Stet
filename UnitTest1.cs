using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace Stet
{
    public class Tests 
    {
        Response des;         
        [Test]
        public void Setup()
        {
            var client = new RestClient("https://disease.sh/v2/all?yesterday=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var z = client.Execute(request);
            des = JsonConvert.DeserializeObject<Response>(z.Content);
        }
 //*************************************************************************        
        [Test]
        public void Test1()
        {
            Assert.NotZero(int.Parse(this.des.TodayDeaths));
        }
 //*************************************************************************
        [Test]
        public void Test2()
        {
            Assert.Less(int.Parse(this.des.DeathsPerOneMillion), 40);
        }
 //*************************************************************************
        [Test]
        public void Test3()
        {
            Assert.Greater(int.Parse(this.des.Recovered), int.Parse(this.des.Deaths));
        }
 //*************************************************************************
        Resp2 rj;
        [Test]
        public void Setup1()
        {
            var client = new RestClient("https://disease.sh/v2/apple/countries/USA");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var z = client.Execute(request);
            rj = JsonConvert.DeserializeObject<Resp2>(z.Content);
        }
//*************************************************************************
        [Test]
        public void Test4()
        {
            StringAssert.Contains("S", rj.Country);
        }
//*************************************************************************
        [Test]
        public void Test5()
        {
            StringAssert.StartsWith("Saint Petersburg", rj.Subregions[97]);
        }
//*************************************************************************
        [Test]
        public void Test6()
        {
            Assert.AreEqual("USA", rj.Country);            
        }
 //*************************************************************************
        Resp1 hj;
        [Test]
        public void Setup2()
        {
            var client = new RestClient("https://disease.sh/v2/countries/Russia?yesterday=false&strict=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var z = client.Execute(request);
            hj = JsonConvert.DeserializeObject<Resp1>(z.Content);
        }
 //*************************************************************************
        [Test]
        public void Test7()
        {
            Assert.AreEqual(int.Parse(this.hj.CountryInfo.Lat), 60);
        }
 //*************************************************************************
        [Test]
        public void Test8()
        {
            Assert.AreEqual("Europe", hj.Continent);
        }
    }
}