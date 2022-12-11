﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.ExternalServices.AwsS3.Models
{
    public  class TokenAws
    {
        public string AccessDevice { get; set; }
        public string Token { get; set; }
        public string UserEdit { get; set; }
        public string Status { get; set; }
        public string State { get; set; }
        public string AwsAccessKey { get; set; }
        public string AwsSecretKey { get; set; }
        public string AwsSessionToken { get; set; }
        public string ProfileId { get; set; }

    }
}
