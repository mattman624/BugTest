using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTest.Models;
using Highway.Data;

namespace BugTest
{
    public class ShipQuery : Scalar<Ship>
    {
        public ShipQuery(long id)
        {
            ContextQuery = c => c.AsQueryable<Ship>().SingleOrDefault(s => s.Id == id);
        }
    }
}
