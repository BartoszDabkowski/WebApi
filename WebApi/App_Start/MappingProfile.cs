using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
        }
    }
}