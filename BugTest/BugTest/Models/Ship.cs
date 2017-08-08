using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BugTest.Models
{
    public class Ship : EntityBase
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        [ForeignKey("Captain")]
        public long? CaptainId { get; set; }
        public Captain Captain { get; set; }
    }
}
