using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class ActorController : Controller
    {
        //[HttpPost]
        //public ActionResult Create(actor obj)
        //{
        //    var service = new Service.ServiceClient();
        //    Service.actor actor = new Service.actor
        //    {
        //        act_fname = obj.act_fname,
        //        act_gender = obj.act_gender,
        //        act_lname = obj.act_lname,
        //        act_fullname = obj.act_fname + " " + obj.act_lname,
        //    };

        //    service.CreateActor(actor);

        //    TempData["successCreate"] = "Create Successfully";

        //    return RedirectToAction("Read", "Actor", new { area = "Admin" });
        //}

        public ActionResult Read()
        {
            //var service = new Service.ServiceClient();
            //var lstService = service.GetAllActors();

            //List<actor> lstActors = new List<actor>();
            //foreach (var item in lstService)
            //{
            //    actor actor = new actor(item);
            //    lstActors.Add(actor);
            //}
            //return View(lstActors);
            return View();
        }

        //[HttpPost]
        //public ActionResult Update(actor obj)
        //{
        //    var service = new Service.ServiceClient();
        //    Service.actor recentActor = service.GetActorById(obj.act_id);

        //    Service.actor actor = new Service.actor
        //    {
        //        act_id = obj.act_id,
        //        act_fname = obj.act_fname,
        //        act_lname = obj.act_lname,
        //        act_fullname = recentActor.act_fullname
        //    };

        //    if (obj.act_gender == 0)
        //    {
        //        actor.act_gender = recentActor.act_gender;
        //    }
        //    else
        //    {
        //        actor.act_gender = obj.act_gender;

        //    }
        //    service.UpdateActor(actor.act_id, actor);

        //    TempData["successUpdate"] = "Update Successfully";
        //    return RedirectToAction("Read", "Actor", new { area = "Admin" });
        //}
    }
}