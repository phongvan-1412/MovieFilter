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

        public reviewer(MovieService.reviewer reviewer)
        {
            rev_id = reviewer.rev_id;
            rev_name = reviewer.rev_name;
            history = reviewer.history;
            rev_email = reviewer.rev_email;
            rev_password = reviewer.history;
        }

        public int rev_id { get; set; }
        public string rev_name { get; set; }
        public string history { get; set; }
        public string rev_email { get; set; }
        public string rev_password { get; set; }
    }
}