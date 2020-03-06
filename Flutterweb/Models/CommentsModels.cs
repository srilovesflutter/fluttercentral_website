using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Flutterweb.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
        public int Level { get; set; }
        public int RootID { get; set; }
        public DateTime CommentedOn { get; set; }
        public int Article_ID { get; set; }
        public bool Draft { get; set; }

        public class SQLDbConnection : DbContext
        {
            public DbSet<Comment> CommentsViewModels { get; set; }
        }

    }
}
