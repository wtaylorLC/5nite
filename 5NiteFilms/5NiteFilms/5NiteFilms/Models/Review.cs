using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class Review
    {
        //primary key for Review table
        [Key]
        public int ReviewID { get; set; }
        public string Descripton { get; set; }
        public int Ratings { get; set; }
        
        //linked to the ReviewComment table
        public ICollection<ReviewComment> reviewcomments { get; set; }
    }
}