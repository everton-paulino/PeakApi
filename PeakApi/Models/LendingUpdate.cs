﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Models
{
    public class LendingUpdate
    {
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public int InstallmentsNumber { get; set; }
        public float InstallmentsValue { get; set; }
    }
}
