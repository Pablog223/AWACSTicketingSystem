using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AWACSTicketSystemWeb.Models;

namespace AWACSTicketSystemWeb.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(LoginViewModel account)
        {
            if (ModelState.IsValid)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    db.LoginView.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Username + " has succesfully registered!";
            }
            return View();
        }

        //Login
        public ActionResult Login()
        { 
            return View(); 
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel user)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var usr = db.LoginView.Single(u => u.Username == user.Username && u.Password == user.Password);
                if (usr != null)
                {
                    Session["WorkerID"] = usr.WorkerID.ToString();
                    Session["Name"] = usr.Username.ToString ();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong.");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["WorkerID"] != null)
            {
                return View();

            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}