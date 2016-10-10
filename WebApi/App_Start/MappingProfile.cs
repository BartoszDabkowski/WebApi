using AutoMapper;
using WebApi.Core.Dtos;
using WebApi.Core.Models.Entities;
using WebApi.Core.Models.JoinModels;

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