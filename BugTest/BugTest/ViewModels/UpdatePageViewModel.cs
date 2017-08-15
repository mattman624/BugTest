using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using BugTest.Models;
using Highway.Data;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public class UpdatePageViewModel : ViewModelBase
    {
       public UpdatePageViewModel(IRepository repo, INavigationService navigationService) : base(repo, navigationService)
        {
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            var ship = Repository.Find(new ShipQuery(1));

            Ship newShip = new Ship()
            {
                Capacity = 3,
                CaptainId = 1,
                Id = 1,
                Name = "Just update"
            };

            if (ship != null)
            {
                ship.Capacity = 99999;
                Repository.Context.Update(ship);
                Repository.Context.Commit();
            }

            base.OnNavigatedTo(parameters);
        }
    }
}
