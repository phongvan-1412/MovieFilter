using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MovieFilterSp.Models
{
    public class genre
    {
        public genre() {}

        //public genre(Service.genre wcfGenre)
        //{
        //    this.gen_id = wcfGenre.gen_id;
        //    this.gen_title = wcfGenre.gen_title;
        //}

        public int gen_id { get; set; }
        public string gen_title { get; set; }

    }
}