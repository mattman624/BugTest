using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using BugTest.Contract;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        public DelegateCommand GoCommand { get; set; }
        public ViewAViewModel(INetworkConnection networkConnection, INavigationService navigationService) : base(networkConnection, navigationService)
        {
            GoCommand = new DelegateCommand(Go);
        }

        private async void Go()
        {
            await NavigationService.NavigateAsync("TestPage");
        }
    }
}
