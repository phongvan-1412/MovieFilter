using MovieFilterSp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class GenreController : Controller
    {
        public ActionResult Read()
        {
            var service = new MovieService.ServiceClient();
            var lstService = service.GetAllGenres();

            List<genre> lstGenres = new List<genre>();
            foreach (var item in lstService)
            {
                genre genre = new genre(item);
                lstGenres.Add(genre);
            }

            return View(lstGenres);
        }

        [HttpPost]
        public ActionResult Create(genre obj)
        {
            var service = new MovieService.ServiceClient();
            MovieService.genre genre = new MovieService.genre
            {
                gen_title = obj.gen_title
            };

            var result = service.InsertGenre(genre);

            TempData["successCreate"] = result;

            return RedirectToAction("Read", "Genre", new { area = "Admin" });
        }

        [HttpPost]
        public ActionResult Update(genre obj)
        {
            var service = new MovieService.ServiceClient();
            MovieService.genre genre = new MovieService.genre
            {
                gen_id = obj.gen_id,
                gen_title = obj.gen_title
            };

            var result = service.UpdateGenre(genre);

            TempData["successUpdate"] = result;
            return RedirectToAction("Read", "Genre", new { area = "Admin" });
        }
    }
}