namespace WebApi.Models
{
    public class ModelFactory
    {
        public CommentWithUserDetails Create(Comment comment, ApplicationUser user)
        {
            return new CommentWithUserDetails
            {
                Id = comment.Id,
                PostId = comment.PostId,
                Body = comment.Body,
                DateTime = comment.DateTime,
                Name = user.Name
            };
        }

        public PostWithUserDetails Create(Post post, ApplicationUser user)
        {
            return new PostWithUserDetails
            {
                Id = post.Id,
                UserId = post.UserId,
                User = post.User,
                Title = post.Title,
                Body = post.Body,
                DateTime = post.DateTime,
                Name = user.Name
            };
        }
    }
}