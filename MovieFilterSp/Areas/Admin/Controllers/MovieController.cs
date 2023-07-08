using MovieFilterSp.Models;
using MovieFilterSp.MovieService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Read()
        {
            ViewData["lstCountries"] = Country();
            ViewData["lstLanguages"] = Language();
            ViewData["lstHour"] = Hours();
            ViewData["lstMinute"] = Minutes();
            ViewData["lstYears"] = Years();
            ViewData["lstActors"] = Actors();
            ViewData["lstDirectors"] = Directors();
            ViewData["lstGenres"] = Genres();
            ViewData["lstMovies"] = Movies();

            return View();
        }
        
        [HttpPost]
        public ActionResult Create(int hr, Int64 min, string lstMovCast, string mov_rel_country, string lstDirectors, string lstGenres, Models.movie obj)
        {
            MovieService.movie postMovie;
            var service = new MovieService.ServiceClient();

            //Insert Movie
            int convertHour = hr * 60;
            postMovie = new MovieService.movie
            {
                mov_id = obj.mov_id,
                mov_title = Regex.Replace(obj.mov_title, "[$&+,:;=?@#|'<>.^*()%!-]", " "),
                mov_year = obj.mov_dt_rel.Substring(0, 4),
                mov_time = (convertHour + min).ToString(),
                mov_dt_rel = obj.mov_dt_rel.Substring(5),
                mov_lang = obj.mov_lang,
                mov_rel_country = mov_rel_country
            };

            var result = service.InsertMovie(postMovie);
            var insertedMovie = new Models.movie(result);

            //Insert Movie_cast
            var jsonMovCastText = JsonConvert.SerializeObject(lstMovCast);
            var jsonMovCast = JsonConvert.DeserializeObject(jsonMovCastText);
            List<movcast> listMovCast = JsonConvert.DeserializeObject<List<movcast>>(jsonMovCast.ToString());
            MovieService.movie_cast movie_cast;
            foreach (var item in listMovCast)
            {
                movie_cast = new MovieService.movie_cast
                {
                    mov_id = insertedMovie.mov_id,
                    act_id = service.GetActorByName(item.act_name),
                    role = item.role_name,
                };
                service.InsertMovCast(movie_cast);
            }

            //Insert Movie_direction
            MovieService.movie_direction movie_direction;
            foreach (var item in lstDirectors.Split(','))
            {
                movie_direction = new MovieService.movie_direction
                {
                    mov_id = insertedMovie.mov_id,
                    dir_id = service.GetDirectorByName(item),
                };
                service.InsertMovDir(movie_direction);
            }

            //Insert Movie_genres
            MovieService.movie_genres movie_genres;
            foreach (var item in lstGenres.Split(','))
            {
                movie_genres = new MovieService.movie_genres
                {
                    mov_id = insertedMovie.mov_id,
                    gen_id = service.GetGenreByName(item),
                };
                service.InsertMovGen(movie_genres);
            }

            if(result == null)
            {
                TempData["createMovie"] = "Something wrong in server";
            }
            TempData["createMovie"] = "Create successfully";
            return RedirectToAction("Read", "Movie", "Admin");
        }

        //[HttpPost]
        //public ActionResult Update(Models.movie obj)
        //{
        //    string result;
        //    Service.movie postData;

        //    postData = new Service.movie
        //    {
        //        mov_id = obj.mov_id,
        //        mov_title = obj.mov_title,
        //        mov_year = obj.mov_year,
        //        mov_time = obj.mov_time,
        //        mov_dt_rel = obj.mov_dt_rel,
        //        mov_lang = obj.mov_lang
        //    };
        //    var service = new Service.ServiceClient();
        //    service.CreateMovie(postData);
        //    TempData["updateActor"] = "Update Actor successfully";

        //    return RedirectToAction("Read", "Actor", "Admin");
        //}

        //[HttpPost]
        //public JsonResult Sort(string sort, string by, int movie)
        //{
        //    var client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:44345/");

        //    var responseMovie = client.GetAsync("movie/getbyid/" + movie).Result.Content.ReadAsStringAsync().Result;
        //    var jsonMovie = JsonConvert.DeserializeObject(responseMovie);
        //    Models.movie mov = JsonConvert.DeserializeObject<Models.movie>(jsonMovie.ToString());

        //    //19+20
        //    if (sort.Equals("5"))
        //    {
        //        if (by.Equals("13"))
        //        {
        //            mov.ratings = mov.ratings.OrderBy(r => r.reviewer.rev_name).ToList();
        //        }
        //        else
        //        {
        //            mov.ratings = mov.ratings.OrderBy(r => Convert.ToInt32(r.rev_stars)).ToList();
        //        }
        //    }
        //    else
        //    {
        //        if (by.Equals("13"))
        //        {
        //            mov.ratings = mov.ratings.OrderByDescending(r => r.reviewer.rev_name).ToList();
        //        }
        //        else
        //        {
        //            mov.ratings = mov.ratings.OrderByDescending(r => Convert.ToInt32(r.rev_stars)).ToList();
        //        }
        //    }
        //    return Json(mov.ratings);
        //}

        public List<int> Hours()
        {
            List<int> hour = new List<int>();
            for (int i = 1; i <= 24; i++)
            {
                hour.Add(i);
            }
            return hour;
        }
        public List<Int64> Minutes()
        {
            List<Int64> min = new List<Int64>();
            for (Int64 i = 1; i <= 60; i++)
            {
                min.Add(i);
            }
            return min;
        }
        public List<int> Years()
        {
            List<int> years = new List<int>();
            for (int i = 1991; i < 2100; i++)
            {
                years.Add(i);
            }
            return years;
        }
        public List<country> Country()
        {
            string countryText = System.IO.File.ReadAllText(@"C:\Aptech\SEM3\Web Service\MovieFilter\MovieFilterSp\Utils\countries.json");
            string countryJson = JsonConvert.SerializeObject(countryText);
            var countriesText = JsonConvert.DeserializeObject(countryJson);
            List<country> countries = JsonConvert.DeserializeObject<List<country>>(countriesText.ToString());
            return countries;
        }
        public List<language> Language()
        {
            string languageText = System.IO.File.ReadAllText(@"C:\Aptech\SEM3\Web Service\MovieFilter\MovieFilterSp\Utils\languages.json");
            string languageJson = JsonConvert.SerializeObject(languageText);
            var languagesText = JsonConvert.DeserializeObject(languageJson);
            List<language> languages = JsonConvert.DeserializeObject<List<language>>(languagesText.ToString());
            return languages;
        }

        public List<Models.actor> Actors()
        {
            var service = new MovieService.ServiceClient();
            var lstService = service.GetAllActors();

            List<Models.actor> lstActors = new List<Models.actor>();
            foreach (var item in lstService)
            {
                Models.actor actor = new Models.actor(item);
                lstActors.Add(actor);
            }

            return lstActors;
        }
        public List<Models.director> Directors()
        {
            var service = new MovieService.ServiceClient();
            var lstService = service.GetAllDirectors();

            List<Models.director> lstDirectors = new List<Models.director>();
            foreach (var item in lstService)
            {
                Models.director director = new Models.director(item);
                lstDirectors.Add(director);
            }

            return lstDirectors;
        }
        public List<Models.genre> Genres()
        {
            var service = new MovieService.ServiceClient();
            var lstGenreService = service.GetAllGenres();
            var lstMovieService = service.GetAllMovies();

            List<Models.movie> lstMovie = new List<Models.movie>();
            List<Models.genre> lstGenres = new List<Models.genre>();

            foreach (var item in lstMovieService)
            {
                Models.movie movie = new Models.movie(item);
                lstMovie.Add(movie);
            }
            foreach (var item in lstGenreService)
            {
                Models.genre genre = new Models.genre(item);
                lstGenres.Add(genre);
            }

            //foreach (var item in lstMovieService)
            //{
            //    foreach (var i in lstGenreService)
            //    {
            //        i.movie_genres = item.movie_genres;
            //    }
            //}

            return lstGenres;
        }
        public List<Models.movie> Movies()
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