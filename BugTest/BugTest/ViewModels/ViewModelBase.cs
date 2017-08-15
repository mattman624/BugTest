using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway.Data;
using Prism.Mvvm;
using Prism.Navigation;

namespace BugTest.ViewModels
{
    public abstract class ViewModelBase : BindableBase, INavigatedAware
    {
        protected IRepository Repository;
        protected INavigationService NavService;

        protected ViewModelBase(IRepository repo, INavigationService navigationService)
        {
            Repository = repo;
            NavService = navigationService;
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
           
        }
    }
}
