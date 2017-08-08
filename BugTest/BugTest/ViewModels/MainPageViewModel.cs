using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using BugTest.Contract;
using BugTest.Models;
using Microsoft.EntityFrameworkCore;
using Plugin.DeviceOrientation;
using Plugin.DeviceOrientation.Abstractions;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public class MainPageViewModel 
    {
        public MainPageViewModel(INetworkConnection networkConnection, INavigationService navigationService) 
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

            using (var ctx = new BugTestContext(new DbContextOptions<BugTestContext>()))
            {
                ctx.Database.EnsureCreated();
                ctx.Add(lela);
                ctx.Add(ship);
                ctx.SaveChanges();
            }
        }
    }
}
