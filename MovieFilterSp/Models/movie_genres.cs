using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFilterSp.Models
{
    public class movie_genres
    {
        public int movie_genres_id { get; set; }
        public int mov_id { get; set; }
        public int gen_id { get; set; }
    }
}