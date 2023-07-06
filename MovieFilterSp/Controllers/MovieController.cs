using MovieFilterSp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MovieFilterSp.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            ViewData["lstYear"] = Year();
            //ViewData["lstGenres"] = Genres();
            //ViewData["lstMovies"] = Movies();
            return View();
        }

        //public ActionResult Detail(int movId)
        //{
        //    var service = new Service.ServiceClient();
        //    var mov = service.GetMovieById(movId);
        //    return View(mov);
        //}

        public List<Int64> Year()
        {
            List<Int64> year = new List<Int64>();
            for (int i = 1990; i <= 2100; i++)
            {
                year.Add(i);
            }
            return year;
        }

        //public List<genre> Genres()
        //{
        //    var service = new Service.ServiceClient();
        //    var arrGenres = service.GetAllGenres();

        //    List<genre> lstGenres = new List<genre>();
        //    foreach (var item in arrGenres)
        //    {
        //        genre genre = new genre(item);
        //        lstGenres.Add(genre);
        //    }

        //    return lstGenres;
        //}

        //public List<movie> Movies()
        //{
        //    var service = new Service.ServiceClient();
        //    var lstService = JsonConvert.DeserializeObject(service.GetAllMovies());
        //    List<movie> lstMovies = JsonConvert.DeserializeObject<List<movie>>(lstService.ToString());

        //    return lstMovies;
        //}
    }
}