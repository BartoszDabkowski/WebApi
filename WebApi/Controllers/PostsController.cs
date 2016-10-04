﻿using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Dtos;
using WebApi.Models;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class PostsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPosts()
        {
            var posts = _unitOfWork.Posts.GetPosts();

            return posts.Select(Mapper.Map<PostWithUserDetails, PostDto>);
        }

        [HttpGet]
        [Route("api/posts/{postId}/comments")]
        public IEnumerable<CommentDto> GetPostComments(int postId)
        {
            var comments = _unitOfWork.Posts.GetPostComments(postId).ToList();

            return comments.Select(Mapper.Map<CommentWithUserDetails, CommentDto>);
        }

        [HttpGet]
        [Route("api/posts/{userId}")]
        public IEnumerable<PostDto> GetPostsByUser(string userId)
        {
            var comments = _unitOfWork.Posts.GetPostsByUser(userId).ToList();

            return comments.Select(Mapper.Map<PostWithUserDetails, PostDto>);
        }
    }
}
