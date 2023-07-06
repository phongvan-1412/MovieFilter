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

        //public movie(Service.movie wcfMovie)
        //{
        //    this.mov_id = wcfMovie.mov_id;
        //    this.mov_title = wcfMovie.mov_title;
        //    this.mov_year = wcfMovie.mov_year;
        //    this.mov_time = wcfMovie.mov_time;
        //    this.mov_lang = wcfMovie.mov_lang;
        //    this.mov_dt_rel = wcfMovie.mov_dt_rel;
        //    this.mov_rel_country = wcfMovie.mov_rel_country;
        //}

        public int mov_id { get; set; }
        public string mov_title { get; set; }
        public string mov_year { get; set; }
        public string mov_time { get; set; }
        public string mov_lang { get; set; }
        public string mov_dt_rel { get; set; }
        public string mov_rel_country { get; set; }
    }
}