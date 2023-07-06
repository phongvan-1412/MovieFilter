using MovieFilterSp.MovieService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MovieFilterSp.Controllers
{
    public class ReviewerController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Register(Models.reviewer reviewer)
        //{
        //    var service = new ServiceClient();

        //    Service.reviewer postData = new Service.reviewer
        //    {
        //        rev_name = reviewer.rev_name,
        //        rev_email = reviewer.rev_email,
        //        rev_password = EncryptPassword(reviewer.rev_password),
        //    };

        //    try
        //    {
        //        service.CreateReviewer(postData);
        //        TempData["createReviewer"] = "Account registed";
        //    }
        //    catch (Exception)
        //    {
        //        TempData["createFlag"] = "Failed";

        //    }

        //    return RedirectToAction("Login", "Reviewer");
        //}

        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(Models.reviewer reviewer)
        //{
        //    var service = new ServiceClient();
        //    Service.reviewer accountExist = service.GetReviewerByEmail(reviewer.rev_email);
        //    if (accountExist == null || !DecryptPassword(accountExist.rev_password).Equals(reviewer.rev_password) || !accountExist.rev_email.Equals(reviewer.rev_email))
        //    {
        //        TempData["accountFailed"] = "Email or password is invalid. Please try again!";
        //    }
        //    else
        //    {
        //        TempData["accountVerified"] = "Log in successfully";
        //        Session["account"] = accountExist;
        //    }

        //    return View();
        //}

        //public ActionResult Logout()
        //{
        //    Session["account"] = null;
        //    return RedirectToAction("Index", "Movie");
        //}

        public static string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return null;
            }
            else
            {
                byte[] storePassword = ASCIIEncoding.ASCII.GetBytes(password);
                string encryptedPassword = Convert.ToBase64String(storePassword);
                return encryptedPassword;
            }
        }

        public static string DecryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return null;
            }
            else
            {
                byte[] encryptedPassword = Convert.FromBase64String(password);
                string decryptedPassword = ASCIIEncoding.ASCII.GetString(encryptedPassword);
                return decryptedPassword;
            }
        }
    }
}