using System.Net.Http;
using System.Web.Http.Routing;
using WebApi.Models.JoinModels;

namespace WebApi.Dtos
{
    public class DtoFactory
    {
        private readonly UrlHelper _uriHelper;

        public DtoFactory(HttpRequestMessage request)
        {
            _uriHelper = new UrlHelper(request);
        }

        public CommentDto Create(CommentWithUserDetails comment)
        {
            return new CommentDto()
            {
                Id = comment.Id,
                PostId = comment.PostId,
                Body = comment.Body,
                Name = comment.Name,
                Url = _uriHelper.Link("Comments", new { commentId = comment.Id})

            };
        }

        public CommentV2Dto CreateV2(CommentWithUserDetails comment)
        {
            return new CommentV2Dto()
            {
                Id = comment.Id,
                PostId = comment.PostId,
                Body = comment.Body,
                DateTime = comment.DateTime,
                Name = comment.Name,
                Url = _uriHelper.Link("Comments", new { commentId = comment.Id, v = 2 })

            };
        }

        public PostDto Create(PostWithUserDetails post)
        {
            return new PostDto()
            {
                Id = post.Id,
                UserId = post.UserId,
                Body = post.Body,
                DateTime = post.DateTime,
                Name = post.Name,
                Title = post.Title,
                Url = _uriHelper.Link("Posts", new { postId = post.Id})
            };
        }
    }
}