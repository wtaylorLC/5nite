using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class MovieDirector
    {
        //primary key for the movie director table
        [Key]
        public int MovieDirectorID { get; set; }
        public string Producer { get; set; }
        public string writers { get; set; }
        public int DirectorID { get; set; }
        public int MovieID { get; set; }
        public virtual Director Director { get; set; }
        public virtual Movie Movie { get; set; }
    }
}