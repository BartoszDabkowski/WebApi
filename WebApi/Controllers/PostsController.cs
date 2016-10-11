using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Core;
using WebApi.Core.Dtos;
using WebApi.Core.Models.Entities;
using WebApi.Core.Repositories;
using WebApi.Persistence;

namespace WebApi.Controllers
{
    public class PostsController : BaseApiController
    {
        public PostsController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        [HttpGet]
        public IHttpActionResult GetPost(int postId)
        {
            var post = UnitOfWork.Posts.GetPostsWithUserDetails()
                                    .SingleOrDefault(p => p.Id == postId);
            if(post == null)
                return NotFound();

            return Ok(DtoFactory.Create(post));
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPosts()
        {
            var posts = UnitOfWork.Posts.GetPostsWithUserDetails()
                                    .Select(p => DtoFactory.Create(p));
            return posts;
        }

        [HttpGet]
        public IEnumerable<PostDto> GetPostsByUser(string userId)
        {
            var comments = UnitOfWork.Posts.GetPostsByUser(userId)
                                        .Select(p => DtoFactory.Create(p));
            return comments;
        }

        [HttpGet]
        public IHttpActionResult GetPostByUser(string userId, int postId)
        {
            var post = UnitOfWork.Posts.GetPostByUser(userId, postId);

            if (post == null)
                return NotFound();

            return Ok(DtoFactory.Create(post));
        }

        [HttpPost]
        public IHttpActionResult PostPost([FromBody]PostDto model)
        {
            if (model == null)
                return BadRequest();
            
            var user = UnitOfWork.Users.GetUser(model.UserId);

            if(user == null)
                return NotFound();

            var post = new Post()
            {
                UserId = model.UserId,
                Body = model.Body,
                Title = model.Title,
                DateTime = DateTime.Now
            };

            UnitOfWork.Posts.Add(post);
            UnitOfWork.Complete();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult PostPost(int postId)
        {
            var post = UnitOfWork.Posts.GetPost(postId);

            if(post == null)
                return NotFound();

            UnitOfWork.Posts.Remove(post);
            UnitOfWork.Complete();

            return Ok();
        }
    }
}
