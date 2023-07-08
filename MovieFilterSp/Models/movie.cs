using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MovieFilterSp.Models
{
    public class movie
    {
        public movie() {}

        public movie(MovieService.movie wcfMovie)
        {
            mov_id = wcfMovie.mov_id;
            mov_title = wcfMovie.mov_title;
            mov_year = wcfMovie.mov_year;
            mov_time = wcfMovie.mov_time;
            mov_lang = wcfMovie.mov_lang;
            mov_dt_rel = wcfMovie.mov_dt_rel;
            mov_rel_country = wcfMovie.mov_rel_country;
        }

        public int mov_id { get; set; }
        public string mov_title { get; set; }
        public string mov_year { get; set; }
        public string mov_time { get; set; }
        public string mov_lang { get; set; }
        public string mov_dt_rel { get; set; }
        public string mov_rel_country { get; set; }
        public List<movie_cast> movie_cast { get; set; }
        public List<movie_direction> movie_direction { get; set; }
        public List<movie_genres> movie_genres { get; set; }

    }
}