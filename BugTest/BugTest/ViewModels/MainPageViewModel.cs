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
    public class MainPageViewModel 
    {
        private IRepository _repo;

        public MainPageViewModel(INetworkConnection networkConnection, INavigationService navigationService,
            IRepository repo) 
        {
            _repo = repo;
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

            _repo.Context.Add(lela);
            _repo.Context.Add(ship);
            _repo.Context.Commit();
        }
    }
}
