using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFilterSp.Models
{
    public class movie_cast
    {
        public int movie_cast_id { get; set; }
        public int act_id { get; set; }
        public int mov_id { get; set; }
        public string role { get; set; }
    }
}