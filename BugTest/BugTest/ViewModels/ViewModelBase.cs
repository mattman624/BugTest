using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTest.Contract;
using Prism.Mvvm;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public abstract class ViewModelBase : BindableBase
    {
        private INetworkConnection NetworkConnection;
        protected INavigationService NavigationService;
        protected ViewModelBase(INetworkConnection networkConnection, INavigationService navigationService)
        {
            NetworkConnection = networkConnection;
            NavigationService = navigationService;
        }


        protected bool IsOnline()
        {
            return NetworkConnection.IsConnectedToInternet();
        }
        
    }
}
