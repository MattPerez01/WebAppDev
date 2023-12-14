using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using T4S_MODEL;
using T4S_BLL;

namespace T4S_Webpage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SignUp(SignUpModel model)
        {

            if (string.IsNullOrWhiteSpace(model.userName))
                return View();
            else
            {
                BLL userSignUp = new BLL();
                string message = userSignUp.SignUp(model);


                return RedirectToAction("SignUpResults", model);
            }

        }

        public ActionResult SignUpResults(SignUpModel model)
        {
            ViewBag.message = model.message;
            return View();
        }

        public ActionResult SignIn(SignInModel model)
        {

            if (string.IsNullOrWhiteSpace(model.userName))
                return View();
            else
            {
                BLL userSignIn = new BLL();
                string message = userSignIn.SignIn(model);


                return RedirectToAction("SignInResults", model);
            }
        }


        public ActionResult SignInResults(SignInModel model)
        {
            ViewBag.message = model.message;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}