using MovieFilterSp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class DirectorController : Controller
    {
        [HttpPost]
        public ActionResult Create(director obj)
        {
            var service = new MovieService.ServiceClient();
            MovieService.director director = new MovieService.director
            {
                dir_fname = obj.dir_fname,
                dir_lname = obj.dir_lname,
                dir_fullname = $"{obj.dir_fname} {obj.dir_lname}",
            };

            var result = service.InsertDirector(director);

            TempData["successCreate"] = result;

            return RedirectToAction("Read", "Director", new { area = "Admin" });
        }

        public ActionResult Read()
        {
            var service = new MovieService.ServiceClient();
            var lstService = service.GetAllDirectors();

            List<director> lstDirectors = new List<director>();
            foreach (var item in lstService)
            {
                director director = new director(item);
                lstDirectors.Add(director);
            }

            return View(lstDirectors);
        }

        [HttpPost]
        public ActionResult Update(director obj)
        {
            var service = new MovieService.ServiceClient();
            MovieService.director recentDirector = service.GetDirectorById(obj.dir_id);

            MovieService.director director = new MovieService.director
            {
                dir_id = obj.dir_id,
                dir_fname = obj.dir_fname,
                dir_lname = obj.dir_lname,
                dir_fullname = $"{obj.dir_fname} {obj.dir_lname}"
            };

            var result = service.UpdateDirector(director);

            TempData["successUpdate"] = result;
            return RedirectToAction("Read", "Director", new { area = "Admin" });
        }
    }
}