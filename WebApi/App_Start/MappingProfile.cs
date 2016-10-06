using AutoMapper;
using WebApi.Dtos;
using WebApi.Models;
using WebApi.Models.Entities;
using WebApi.Models.JoinModels;

namespace WebApi.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<Post, PostDto>();
            Mapper.CreateMap<PostWithUserDetails, PostDto>();
            Mapper.CreateMap<Comment, CommentDto>();
            Mapper.CreateMap<CommentWithUserDetails, CommentDto>();
        }
    }
}