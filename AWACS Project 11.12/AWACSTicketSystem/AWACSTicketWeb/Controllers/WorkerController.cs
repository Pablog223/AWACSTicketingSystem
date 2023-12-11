using AWACSTicketSystemWeb.Data;
using AWACSTicketWeb.Data.Functions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AWACSTicketWeb.Controllers
{
    public class WorkerController : Controller
    {
        private readonly IWorkerService _service;

        public WorkerController (IWorkerService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var allWorkers = _service.GetAll();
            return View(allWorkers);
        }


    }
}
