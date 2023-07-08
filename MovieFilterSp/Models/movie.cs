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

        public movie(MovieService.movie wcfMovie, List<MovieService.movie_cast> wcfMovCasts, List<MovieService.movie_direction> wcfMovDirs, List<MovieService.movie_genres> wcfMovGens)
        {
            mov_id = wcfMovie.mov_id;
            mov_title = wcfMovie.mov_title;
            mov_year = wcfMovie.mov_year;
            mov_time = wcfMovie.mov_time;
            mov_lang = wcfMovie.mov_lang;
            mov_dt_rel = wcfMovie.mov_dt_rel;
            mov_rel_country = wcfMovie.mov_rel_country;
            movie_cast = new List<movie_cast>();
            movie_direction = new List<movie_direction>();
            movie_genres = new List<movie_genres>();

            foreach (var movcast in wcfMovCasts)
            {
                var movcastTmp = new Models.movie_cast
                {
                    movie_cast_id = movcast.movie_cast_id,
                    mov_id = movcast.mov_id,
                    act_id = movcast.act_id,
                    role = movcast.role
                };
                this.movie_cast.Add(movcastTmp);
            }
            foreach (var movdir in wcfMovDirs)
            {
                var movDirTmp = new Models.movie_direction
                {
                    movie_director_id = movdir.movie_director_id,
                    mov_id = movdir.mov_id,
                    dir_id = movdir.dir_id
                };
                this.movie_direction.Add(movDirTmp);
            }
            foreach (var movgen in wcfMovGens)
            {
                var movgenTmp = new Models.movie_genres
                {
                    movie_genres_id = movgen.movie_genres_id,
                    mov_id = movgen.mov_id,
                    gen_id = movgen.gen_id
                };
                this.movie_genres.Add(movgenTmp);
            }
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