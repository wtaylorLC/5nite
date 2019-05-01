using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class Comment
    {
        //primary key for the comments table
        [Key]
        public int CommentID { get; set; }
        public int Description { get; set; }

        //foreign keys
        public int Id { get; set; }
        public int ActorID { get; set;}
        public int MovieID { get; set; }

        //linked to the ReviewComment table
        public ICollection<ReviewComment> reviewcomments { get; set; }

    }
}