using AutoMapper;
using GMM.Application.Models;
using GMM.Domain.Entities;

namespace GMM.Application.Mappings
{
    public class ProccessProfile : Profile
    {
        public ProccessProfile()
        {
            CreateMap<ModelProccess, Proccess>();
            CreateMap<Proccess, ModelProccess>();
        }
    }
}
