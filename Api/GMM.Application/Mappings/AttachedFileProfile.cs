using AutoMapper;
using GMM.Application.Models;
using GMM.Application.Request.PersonController;
using GMM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Application.Mappings
{
    public class AttachedFileProfile: Profile
    {
        public AttachedFileProfile()
        {
            CreateMap<ModelAttachedFile, AttachedFile>();
            CreateMap<AttachedFile, ModelAttachedFile>();
             
            CreateMap<AttachedFile, AttachedFilesUpdate>();
            CreateMap<AttachedFilesUpdate, AttachedFile>();
        }
    }
}
