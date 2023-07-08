using MovieFilterSp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MovieFilterSp.Areas.Admin.Controllers
{
    public class ReviewerController : Controller
    {
        public ActionResult Read(string searchString, string rated, string rating)
        {
            //    if ((String.IsNullOrEmpty(searchString) || searchString == " ") && String.IsNullOrEmpty(rated) && String.IsNullOrEmpty(rating))
            //    {
            //        searchString = "null";
            //        rated = "null";
            //        rating = "null";
            //    }
            //    else if (searchString == " " || searchString == "")
            //    {
            //        searchString = "null";
            //        if ((String.IsNullOrEmpty(rating) || rating.Equals("Select") || !rating.Equals("Select"))
            //           && (String.IsNullOrEmpty(rated) || !String.IsNullOrEmpty(rated)))
            //        {
            //            if (String.IsNullOrEmpty(rating) || rating.Equals("Select")) { rating = "null"; }
            //            if (String.IsNullOrEmpty(rated)) { rated = "null"; }
            //        }
            //    }
            //    else
            //    {
            //        if ((String.IsNullOrEmpty(rating) || rating.Equals("Select") || !rating.Equals("Select"))
            //           && (String.IsNullOrEmpty(rated) || !String.IsNullOrEmpty(rated)))
            //        {
            //            if (String.IsNullOrEmpty(rating) || rating.Equals("Select")) { rating = "null"; }
            //            if (String.IsNullOrEmpty(rated)) { rated = "null"; }
            //        }
            //        searchString = Regex.Replace(searchString, "[$&+,:;=?@#|'<>.^*()%!-]", " ");
            //    }

            var service = new MovieService.ServiceClient();
            var lstService = service.GetAllReviewers();

            List<reviewer> lstReviewers = new List<reviewer>();
            foreach (var item in lstService)
            {
                reviewer reviewer = new reviewer(item);
                lstReviewers.Add(reviewer);
            }
            return View(lstReviewers);
        }
        public ActionResult Read()
        {
            return View();
        }
    }
}