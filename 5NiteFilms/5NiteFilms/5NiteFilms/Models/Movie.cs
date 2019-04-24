using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class Movie
    {

        //primary key for the Movie table
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Genre { get; set; }


        //link to the MovieActor table
        public ICollection<MovieActor> movieActors { get; set; }

        //linked to the Comment table
        public ICollection<Comment> comments { get; set; }

        //linked to the MovieDirector table
        public ICollection<MovieDirector> movieDirectors { get; set; }
        public ICollection<Movie> movies { get; set; }

    }
}