using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MovieFilterSp.Models
{
    public class director
    {
        public director() {}

        public director(MovieService.director obj)
        {
            dir_id = obj.dir_id;
            dir_fname = obj.dir_fname;
            dir_lname = obj.dir_lname;
            dir_fullname = obj.dir_fullname;
        }

        public int dir_id { get; set; }
        public string dir_fname { get; set; }
        public string dir_lname { get; set; }
        public string dir_fullname { get; set; }
    }
}