using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFilterSp.Models
{
    public class rating
    {
        public int rate_id { get; set; }
        public int mov_id { get; set; }
        public int rev_id { get; set; }
        public int rev_stars { get; set; }
        public int num_o_rating { get; set; }
        public int num_o_viewing { get; set; }
    }
}