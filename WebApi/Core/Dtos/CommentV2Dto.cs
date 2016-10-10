using System;

namespace WebApi.Core.Dtos
{
    public class CommentV2Dto : CommentDto
    {
        public DateTime DateTime { get; set; }
    }
}