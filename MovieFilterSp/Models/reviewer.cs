using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MovieFilterSp.Models
{
    public class reviewer
    {
        public reviewer() {}

        //public reviewer(Service.reviewer reviewer)
        //{
        //    this.rev_id = reviewer.rev_id;
        //    this.rev_name = reviewer.rev_name;
        //    this.history = reviewer.history;
        //    this.rev_email = reviewer.rev_email;
        //    this.rev_password = reviewer.history;
        //}


        public int rev_id { get; set; }
        public string rev_name { get; set; }
        public string history { get; set; }
        public string rev_email { get; set; }
        public string rev_password { get; set; }
    }
}