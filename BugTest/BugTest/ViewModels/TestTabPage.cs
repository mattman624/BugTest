using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using BugTest.Contract;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public class TestTabPage : ViewModelBase
    {
        public TestTabPage(INetworkConnection networkConnection, INavigationService navigationService) : base(networkConnection, navigationService)
        {
        }
    }
}
