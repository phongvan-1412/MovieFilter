using MovieFilterSp.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieFilterSp.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            ViewData["lstYear"] = Year();
            ViewData["lstGenres"] = Genres();
            ViewData["lstMovies"] = Movies();
            return View();
        }

        public ActionResult Detail(int movId)
        {
            var service = new MovieService.ServiceClient();
            var mov = service.GetMovieById(movId);

            Models.movie movie = new Models.movie(mov, mov.movie_cast, mov.movie_direction, mov.movie_genres);
            return View(movie);
        }

        public List<Int64> Year()
        {
            List<Int64> year = new List<Int64>();
            for (int i = 1990; i <= 2100; i++)
            {
                year.Add(i);
            }
            return year;
        }

        public List<genre> Genres()
        {
            var service = new MovieService.ServiceClient();
            var arrGenres = service.GetAllGenres();

            List<genre> lstGenres = new List<genre>();
            foreach (var item in arrGenres)
            {
                genre genre = new genre(item);
                lstGenres.Add(genre);
            }

            return lstGenres;
        }

        public List<movie> Movies()
        {
            var service = new MovieService.ServiceClient();
            var lstMovieService = service.GetAllMovies();

            List<Models.movie> lstMovie = new List<Models.movie>();

            foreach (var item in lstMovieService)
            {
                Models.movie movie = new Models.movie(item, item.movie_cast, item.movie_direction, item.movie_genres);
                lstMovie.Add(movie);
            }

            return lstMovie;
        }
    }
}