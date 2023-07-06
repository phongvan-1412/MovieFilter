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

        //public director(Service.director obj)
        //{
        //    this.dir_id = obj.dir_id;
        //    this.dir_fname = obj.dir_fname;
        //    this.dir_lname = obj.dir_lname;
        //    this.dir_fullname = obj.dir_fullname;
        //}

        public int dir_id { get; set; }
        public string dir_fname { get; set; }
        public string dir_lname { get; set; }
        public string dir_fullname { get; set; }
    }
}