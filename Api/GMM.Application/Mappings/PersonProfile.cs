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
    public class PersonProfile: Profile
    {
        public PersonProfile()
        {
            CreateMap<ModelPerson, Person>();
            CreateMap<Person, ModelPerson>();
        }
    }

}
