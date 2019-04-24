using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5Nite.Models
{
    public class MovieActor
    {
        //Primary key for Move Actor table
        [Key]
        public int MovieActorID { get; set; }
        public string Description { get; set; }

        //foreign key linked from Actor and Movie Table
        public int ActorID { get; set; }
        public int MovieID { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}