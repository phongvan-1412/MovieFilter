using Antlr.Runtime.Misc;
using MovieFilterSp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class ActorController : Controller
    {
        [HttpPost]
        public ActionResult Create(actor obj)
        {
            var service = new MovieService.ServiceClient();
            var insertActor = new MovieService.actor
            {
                act_fname = obj.act_fname,
                act_gender = obj.act_gender,
                act_lname = obj.act_lname,
                act_fullname = $"{obj.act_fname} {obj.act_lname}"
            };
            
            var result = service.InsertActor(insertActor);
            TempData["successCreate"] = result;

            return RedirectToAction("Read", "Actor", new { area = "Admin" });
        }

        public ActionResult Read()
        {
            var service = new MovieService.ServiceClient();
            var lstService = service.GetAllActors();

            List<actor> lstActors = new List<actor>();
            foreach (var item in lstService)
            {
                actor actor = new actor(item);
                lstActors.Add(actor);
            }
            return View(lstActors);
        }

        [HttpPost]
        public ActionResult Update(actor obj)
        {
            var service = new MovieService.ServiceClient();
            MovieService.actor recentActor = service.GetActorById(obj.act_id);

            MovieService.actor actor = new MovieService.actor
            {
                act_id = obj.act_id,
                act_fname = obj.act_fname,
                act_lname = obj.act_lname,
                act_fullname = $"{obj.act_fname} {obj.act_lname}"
            };

            if (obj.act_gender == 0)
            {
                actor.act_gender = recentActor.act_gender;
            }
            else
            {
                actor.act_gender = obj.act_gender;

            }
            var result = service.UpdateActor(actor);

            TempData["successUpdate"] = result;
            return RedirectToAction("Read", "Actor", new { area = "Admin" });
        }
    }
}