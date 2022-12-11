using AutoMapper;
using GMM.Application.Models;
using GMM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Mappings
{
    public class MasterTableProfile : Profile
    {
        public MasterTableProfile()
        {
            CreateMap<ModelMasterTable, MasterTable>();
            CreateMap<MasterTable, ModelMasterTable>();
        }

    }

}
