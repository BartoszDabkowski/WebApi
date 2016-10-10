using System;

namespace WebApi.Core.Dtos
{
    public class PostDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
        public string Url { get; set; }
    }
}