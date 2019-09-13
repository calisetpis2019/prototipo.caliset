using Abp.AutoMapper;
using prototipo.caliset.Models.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace prototipo.caliset.Comments.Dto
{
    [AutoMapFrom(typeof(Comment))]
    public class CreateCommentInput
    {
        public string Commentary { get; set; }
    }
}
