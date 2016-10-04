using System;

namespace WebApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
    }
}