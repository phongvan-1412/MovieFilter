using MovieFilterSp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class GenreController : Controller
    {
        public ActionResult Read()
        {
            //var service = new Service.ServiceClient();
            //var lstService = service.GetAllGenres();

            //List<genre> lstGenres = new List<genre>();
            //foreach (var item in lstService)
            //{
            //    genre genre = new genre(item);
            //    lstGenres.Add(genre);
            //}

            //return View(lstGenres);
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(genre obj)
        //{
        //    var service = new Service.ServiceClient();
        //    Service.genre genre = new Service.genre
        //    {
        //        gen_title = obj.gen_title
        //    };

        //    service.CreateGenre(genre);

        //    TempData["successCreate"] = "Create Successfully";

        //    return RedirectToAction("Read", "Genre", new { area = "Admin" });
        //}

        //[HttpPost]
        //public ActionResult Update(genre obj)
        //{
        //    var service = new Service.ServiceClient();
        //    Service.genre genre = new Service.genre
        //    {
        //        gen_id = obj.gen_id,
        //        gen_title = obj.gen_title
        //    };

        //    service.UpdateGenre(genre.gen_id, genre);

        //    TempData["successUpdate"] = "Update Successfully";
        //    return RedirectToAction("Read", "Genre", new { area = "Admin" });
        //}
    }
}