using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;

namespace BugTest.Contract
{
    public interface ITestPage
    {
        DelegateCommand AsyncCommand { get; set; }
        DelegateCommand SyncCommand { get; set; }
        bool AsyncRan { get; set; }
        string Display { get; set; }
    }
}
