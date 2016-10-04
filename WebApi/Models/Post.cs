using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WebApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<Comment> Comments { get; set; }
        
        public Post()
        {
            Comments = new Collection<Comment>();
        }
    }
}