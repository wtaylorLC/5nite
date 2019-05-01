using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class Genre
    {
        //primary key for the genre table
        //this table is linked to Movies table
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        //linked to the Movie Table to identify the movie genre.
       
    }
}