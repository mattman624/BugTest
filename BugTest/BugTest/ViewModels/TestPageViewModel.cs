using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BugTest.Contract;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public class TestPageViewModel : ViewModelBase, ITestPage
    {
        private IGoogleCall _google;
        public TestPageViewModel(INetworkConnection networkConnection, IGoogleCall googleCall, INavigationService navigationService) 
            : base(networkConnection, navigationService)
        {
            _google = googleCall;
            //AsyncCommand = new DelegateCommand(async);
            SyncCommand = new DelegateCommand(sync);
            AsyncRan = false;
        }

        public bool AsyncRan { get; set; }
        private string _display;

        public string Display
        {
            get { return _display;}
            set { SetProperty(ref _display, value); }
        }

        //public override async void async()
        //{
        //    await NavigationService.NavigateAsync("MainPage");
        //    //if (IsOnline())
        //    //{
        //    //    var result = await _google.CallGoogle();
        //    //    Display = result;
        //    //    AsyncRan = true;
        //    //}
        //}

        private void sync()
        {
            var result = "bananas";

            int number = 9 / 4 + 3;

            string random = $"{result}{number}";
            Display = random;
        }

        public DelegateCommand AsyncCommand { get; set; }
        public DelegateCommand SyncCommand { get; set; }
    }
}
