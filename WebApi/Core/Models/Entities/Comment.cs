using System;

namespace WebApi.Core.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
    }
}