using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class Director
    {
        //primary key for the director table
        [Key]
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
        public string Info { get; set; }

        //linked to the MovieDirector table
        public ICollection<MovieDirector> movieDirectors { get; set; }
    }
}