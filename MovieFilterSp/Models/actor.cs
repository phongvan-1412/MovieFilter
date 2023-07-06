using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MovieFilterSp.Models
{
    public class actor
    {
        public actor() {}

        //public actor(Service.actor wcfGenre)
        //{
        //    this.act_id = wcfGenre.act_id;
        //    this.act_fname = wcfGenre.act_fname;
        //    this.act_lname = wcfGenre.act_lname;
        //    this.act_fullname = wcfGenre.act_fullname;
        //    this.act_gender = wcfGenre.act_gender;
        //}

        public int act_id { get; set; }
        public string act_fname { get; set; }
        public string act_lname { get; set; }
        public string act_fullname { get; set; }
        public int act_gender { get; set; }
    }
}