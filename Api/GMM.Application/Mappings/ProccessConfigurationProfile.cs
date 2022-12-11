using AutoMapper;
using GMM.Application.Models;
using GMM.Domain.Entities;

namespace GMM.Application.Mappings
{
    public class ProccessConfigurationProfile : Profile
    {
        public ProccessConfigurationProfile()
        {
            CreateMap<ModelProccessConfiguration, ProccessConfiguration>();
            CreateMap<ProccessConfiguration, ModelProccessConfiguration>();
        }
    }
}
