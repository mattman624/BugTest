using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTest.Contract
{
    public interface IGoogleCall
    {
        Task<string> CallGoogle();
    }
}
