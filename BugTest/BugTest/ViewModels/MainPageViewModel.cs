using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using BugTest.Contract;
using BugTest.Models;
using Highway.Data;
using Microsoft.EntityFrameworkCore;
using Plugin.DeviceOrientation;
using Plugin.DeviceOrientation.Abstractions;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
       
        public MainPageViewModel(INavigationService navigationService,
            IRepository repo) : base(repo, navigationService)
        {
            
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            var lela = new Captain()
            {
                Id = 1,
                Name = "Leela"
            };

            var ship = new Ship()
            {
                Captain = lela,
                Capacity = 4,
                CaptainId = 1,
                Id = 1,
                Name = "Planet Express Ship"
            };

            Repository.Context.Add(lela);
            Repository.Context.Add(ship);
            Repository.Context.Commit();

            NavService.NavigateAsync("UpdatePage");
            base.OnNavigatedTo(parameters);
        }
    }
}
