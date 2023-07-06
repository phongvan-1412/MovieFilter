using MovieFilterSp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class DirectorController : Controller
    {
        //[HttpPost]
        //public ActionResult Create(director obj)
        //{
        //    var service = new Service.ServiceClient();
        //    Service.director director = new Service.director
        //    {
        //        dir_fname = obj.dir_fname,
        //        dir_lname = obj.dir_lname,
        //        dir_fullname = obj.dir_fname + " " + obj.dir_lname,
        //    };

        //    service.CreateDirector(director);

        //    TempData["successCreate"] = "Create Successfully";

        //    return RedirectToAction("Read", "Director", new { area = "Admin" });
        //}

        public ActionResult Read()
        {
            //var service = new Service.ServiceClient();
            //var lstService = service.GetAllDirectors();

            //List<director> lstDirectors = new List<director>();
            //foreach (var item in lstService)
            //{
            //    director director = new director(item);
            //    lstDirectors.Add(director);
            //}

            //return View(lstDirectors);
            return View();
        }

        //[HttpPost]
        //public ActionResult Update(director obj)
        //{
        //    var service = new Service.ServiceClient();
        //    Service.director recentDirector = service.GetDirectorById(obj.dir_id);

        //    Service.director director = new Service.director
        //    {
        //        dir_id = obj.dir_id,
        //        dir_fname = obj.dir_fname,
        //        dir_lname = obj.dir_lname,
        //        dir_fullname = obj.dir_fname + " " + obj.dir_lname
        //    };

        //    service.UpdateDirector(director.dir_id, director);

        //    TempData["successUpdate"] = "Update Successfully";
        //    return RedirectToAction("Read", "Director", new { area = "Admin" });
        //}
    }
}