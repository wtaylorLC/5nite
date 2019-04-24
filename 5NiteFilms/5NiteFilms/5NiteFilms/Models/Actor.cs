using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class Actor
    {
        //primary key for Actor Table
        [Key]
        public int ActorID { get; set; }
        public string ActorName { get; set; }
        public string Info { get; set; }

        //link to the MovieActor table
        public ICollection<MovieActor> movieActors { get; set; }

        //linked to the Comment table
        public ICollection<Comment> comments { get; set; }
    }
}