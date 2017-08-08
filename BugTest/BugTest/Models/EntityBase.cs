using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTest.Models
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }
    }
}
