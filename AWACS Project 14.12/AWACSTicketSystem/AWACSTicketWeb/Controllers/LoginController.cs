using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AWACSTicketLibrary;

namespace AWACSTicketWeb.Controllers
{
    public class LoginController : BasisController
    {
        private AWACSModelContainer db = new AWACSModelContainer();

        // GET: Login
        public ActionResult Index()
        {
            return View(db.WorkerSet.ToList());
        }

        // GET: Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Worker worker = db.WorkerSet.Find(id);
            if (worker == null)
            {
                return HttpNotFound();
            }

            setWorkerId(id.Value);
            setWorker();

            Session["Username"] = LoggedInWorker.Name + " " + LoggedInWorker.Surname;


            return RedirectToAction ("Index");
        }
    }
}
