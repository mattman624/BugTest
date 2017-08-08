using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using BugTest.Contract;
using BugTest.Models;
using Highway.Data;
using Plugin.DeviceOrientation;
using Plugin.DeviceOrientation.Abstractions;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public string HorizontalLabel => "Horizontal";
        public string VerticalLabel => "Vertical";
        private string _orientation;

        public string Orientation
        {
            get { return _orientation; }
            set { SetProperty(ref _orientation, value); }
        }
        private DeviceOrientations _currentOrientation;
        public DelegateCommand ChangeOrientationCommand { get; set; }
        public DelegateCommand Lock { get; set; }
        public string LabelText { get; set; }
        private IRepository _repo;
        
        public MainPageViewModel(INetworkConnection networkConnection, INavigationService navigationService, IRepository repo) 
            : base(networkConnection, navigationService)
        {
             //CrossDeviceOrientation.Current.CurrentOrientation.ToString();
            _repo = repo;
            _currentOrientation = CrossDeviceOrientation.Current.CurrentOrientation;//DeviceOrientations.Portrait;
            Orientation = _currentOrientation.ToString();
            CrossDeviceOrientation sdf = new CrossDeviceOrientation();
            CrossDeviceOrientation.Current.LockOrientation(_currentOrientation);
            ChangeOrientationCommand = new DelegateCommand(ChangeOrientation);
            Lock = new DelegateCommand(_lock);

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


        private void _lock()
        {
            CrossDeviceOrientation.Current.UnlockOrientation();
        }

        private void ChangeOrientation()
        {
            _currentOrientation = _currentOrientation != DeviceOrientations.Landscape ? DeviceOrientations.Landscape : DeviceOrientations.Portrait;
            CrossDeviceOrientation.Current.LockOrientation(_currentOrientation);
            Orientation = _currentOrientation.ToString();
        }
    }
}
