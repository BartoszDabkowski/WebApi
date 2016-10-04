﻿using System;

namespace WebApi.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
    }
}