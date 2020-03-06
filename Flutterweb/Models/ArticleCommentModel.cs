using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flutterweb.Models
{
    public class ArticleCommentModel
    {
        public Article article { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}