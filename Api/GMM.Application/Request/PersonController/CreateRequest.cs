﻿using GMM.Application.Models;
using GMM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Request.PersonController
{

    public class CreateRequest
    {    
        public ModelPerson Person { get; set; }
        public List<ModelAttachedFile> ListAttachedFile { get; set; } 

    }

}
