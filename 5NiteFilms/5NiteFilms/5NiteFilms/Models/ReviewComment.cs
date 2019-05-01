using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class ReviewComment
    {
        //primary key for the ReviewComment table
        [Key]
        public int CommentReviewID { get; set; }
        public DateTime CommentDate { get; set; }

        //Foreign keys
        public int CommentID { get; set; }
        public int ReviewID { get; set; }

        public virtual Review Review { get; set; }
        public virtual Comment Comment { get; set; }


    }
}