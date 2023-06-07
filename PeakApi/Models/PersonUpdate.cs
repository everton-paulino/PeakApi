using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Models
{
    public class PersonUpdate
    {
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public String Name { get; set; }
        public int documents { get; set; }
    }
}
