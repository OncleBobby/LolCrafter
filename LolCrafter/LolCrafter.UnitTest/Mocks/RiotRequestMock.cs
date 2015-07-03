using LolCrafter.RiotApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolCrafter.UnitTest.Mocks
{
    public class RiotRequestMock : IRiotRequest
    {
        #region Attributes
        #endregion


        #region Implement IRiotRequest
        public string EndPoint { get; set; }
        public string ApiKey { get; set; }
        public string Region { get; set; }
        public string Version { get; set; }
        public string Request(string parameters)
        {
            return "";
        }
        #endregion
    }
}
