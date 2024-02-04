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
    public class TicketsController : Controller
    {
        private AWACSModelContainer db = new AWACSModelContainer();

        // GET: Tickets
        public ActionResult Index(string searchBy, string searchValue)
        {
            try
            {
                var ticketSet = db.TicketSet.Include(t => t.Creator).Include(t => t.Responsible);

                if (string.IsNullOrEmpty(searchValue))
                {
                    TempData["InfoMessage"] = "Please provide search value.";
                    return View(ticketSet);
                }
                else
                {
                    if (searchBy.ToLower() == "TicketId")
                    {
                        var searchByTicketId = db.TicketSet.Where(p => p.TicketId.ToLower().Contains(searchValue.ToLower()));
                        return View(searchByTicketId);
                    }
                    else if (searchBy.ToLower() == "Category")
                    {
                        var searchByCategory = db.TicketSet.Where(p => p.Category.ToLower().Contains(searchValue.ToLower()));
                        return View(searchByCategory);
                    }
                }
                return View(ticketSet.ToList());
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return View();
            }
        }

        // GET: TicketsHome

        public ActionResult TicketsHome()
        {
            var ticketSet = db.TicketSet.Include(t => t.Creator).Include(t => t.Responsible);
            return View(ticketSet.ToList());
        }

        // GET: Tickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.TicketSet.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // GET: Tickets/Create
        public ActionResult Create()
        {
            ViewBag.CreatorId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            ViewBag.ResponsibleId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TicketId,Category,Description,Solution,DateObserved,PlannedEndDate,Progress,Status,CreatorId,ResponsibleId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                db.TicketSet.Add(ticket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreatorId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            ViewBag.ResponsibleId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.TicketSet.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            ViewBag.CreatorId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            ViewBag.ResponsibleId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TicketId,Category,Description,Solution,DateObserved,PlannedEndDate,Progress,Status,CreatorId,ResponsibleId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreatorId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            ViewBag.ResponsibleId = new SelectList(db.WorkerSet.Select(m => new { Id = m.Id, Info = m.Name + " " + m.Surname }), "Id", "Info");
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.TicketSet.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ticket ticket = db.TicketSet.Find(id);
            db.TicketSet.Remove(ticket);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}