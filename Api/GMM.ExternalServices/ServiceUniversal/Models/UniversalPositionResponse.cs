﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.ServiceUniversal.Models
{
    public class UniversalPositionResponse
    {
        public string IdPosition { get; set; }
        public string IdPositionParent { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
