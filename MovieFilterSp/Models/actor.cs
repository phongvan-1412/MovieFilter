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

        public actor(MovieService.actor wcfActor)
        {
            act_id = wcfActor.act_id;
            act_fname = wcfActor.act_fname;
            act_lname = wcfActor.act_lname;
            act_fullname = wcfActor.act_fullname;
            act_gender = wcfActor.act_gender;
        }

        public int act_id { get; set; }
        public string act_fname { get; set; }
        public string act_lname { get; set; }
        public string act_fullname { get; set; }
        public int act_gender { get; set; }
    }
}