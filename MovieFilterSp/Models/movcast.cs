using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFilterSp.Models
{
    public class movcast
    {
        public movcast()
        {
            this.act_name = "";
            this.role_name = "";
        }
        public string act_name { get; set; }
        public string role_name { get; set; }
    }
}