using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BugTest.Contract;
using BugTest.Services;
using BugTest.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Skip)]
namespace BugTest
{
    public partial class App : PrismApplication
    {
        public App()
        {
            //MainPage = new BugTest.MainPage();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

           var result =  NavigationService.NavigateAsync("http://myapp.com/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IGoogleCall, GoogleCaller>();
            Container.RegisterType<INetworkConnection, NetworkConnection>();
            
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
