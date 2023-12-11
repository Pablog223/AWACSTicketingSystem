using AWACSTicketSystemWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace AWACSTicketWeb.Controllers
{
    public class TicketController : Controller
    {

        private readonly DBContext _context;

        public TicketController(DBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allTickets = _context.Tickets.ToList();
            return View(allTickets);
        }
    }
}
