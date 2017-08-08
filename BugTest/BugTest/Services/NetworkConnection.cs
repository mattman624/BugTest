using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTest.Contract;
using Plugin.Connectivity;

namespace BugTest.Services
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnectedToInternet()
        {
            return CrossConnectivity.Current.IsConnected;
        }
    }
}
