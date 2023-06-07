using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Models
{
    public class LendingRequest
    {
        public int InstallmentsNumber { get; set; }
        public float InstallmentsValue { get; set; }
    }
}
