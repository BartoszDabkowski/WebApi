using System;

namespace WebApi.Core.Models.JoinModels
{
    public class CommentWithUserDetails
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
        public string Url { get; set; }
    }
}