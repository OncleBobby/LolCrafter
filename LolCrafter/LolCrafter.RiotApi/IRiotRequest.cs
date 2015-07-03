using System;
namespace LolCrafter.RiotApi
{
    public interface IRiotRequest
    {
        #region Properties
        string ApiKey { get; set; }
        string EndPoint { get; set; }
        string Region { get; set; }
        string Version { get; set; }
        #endregion

        #region Methods
        string Request(string parameters);
        #endregion
    }
}
