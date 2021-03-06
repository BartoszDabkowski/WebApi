﻿using System;
using WebApi.Core.Models.Entities;

namespace WebApi.Core.Models.JoinModels
{
    public class PostWithUserDetails
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}