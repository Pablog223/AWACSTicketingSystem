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
    public class BasisController : Controller
    {
        protected AWACSModelContainer db = new AWACSModelContainer();

        private static String WorkerIdKey = "WorkerId";

        public Worker setWorker()
        {
            int? workerId = Session[WorkerIdKey] as int?;
            if (workerId == null) return null;
            Worker res = db.WorkerSet.Find(workerId);
            if (res == null) return null;
            Session["IdKey"] = res;
            ViewBag.Worker = res;
            System.Diagnostics.Debug.WriteLine($"Viewbag.Worker.Id: {res.Id}");
            _LoggedInWorker = res;
            return res;
        }

        private Worker _LoggedInWorker = null;
        protected Worker LoggedInWorker => _LoggedInWorker ?? setWorker();

        protected bool hasWorker()
        {
            return LoggedInWorker != null;
        }

        protected void setWorkerId(int workerId)
        {
            Session[WorkerIdKey] = workerId;
        }

        




    }
}
