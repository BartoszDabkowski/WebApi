﻿using System;
using System.Linq.Expressions;

namespace WebApi.Models
{
    public class ModelFactory
    {
        public Expression<Func<Comment, ApplicationUser, CommentWithUserDetails>> CreateCommentWithUserDetails()
        {
            return (comment, user) => new CommentWithUserDetails
            {
                Id = comment.Id,
                PostId = comment.PostId,
                Body = comment.Body,
                DateTime = comment.DateTime,
                Name = user.Name
            };
        }

        public Expression<Func<Post, ApplicationUser, PostWithUserDetails>> CreatePostWithUserDetails()
        {
            return (post, user) => new PostWithUserDetails
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