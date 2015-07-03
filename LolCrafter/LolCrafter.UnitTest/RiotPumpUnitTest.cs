using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LolCrafter.RiotApi;
using LolCrafter.UnitTest.Mocks;

namespace LolCrafter.UnitTest
{
    [TestClass]
    public class RiotPumpUnitTest
    {
        [TestMethod]
        [DeploymentItem("Data/RiotPump/champion.json", "Data/RiotPump")]
        public void TestRequestChampion()
        {
            IRiotRequest riotRequest = 
                new RiotRequestMock
                {
                    EndPoint = "https://na.api.pvp.net/api/lol/",
                    Region = "na",
                    Version = "v1.2",
                    ApiKey = "34f0eef3-4ab0-48c2-a12c-1f3734561325"
                };
            string result = riotRequest.Request("champions");
        }
    }
}
