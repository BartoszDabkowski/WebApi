﻿using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<PostWithUserDetails, PostDto>();

        }
    }
}