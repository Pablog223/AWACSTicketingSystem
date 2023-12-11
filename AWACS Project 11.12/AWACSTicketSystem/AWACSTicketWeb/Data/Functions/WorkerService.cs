using AWACSTicketSystemWeb.Data;
using AWACSTicketSystemWeb.Models;

namespace AWACSTicketWeb.Data.Functions
{
    public class WorkerService : IWorkerService
    {
        private readonly DBContext _context;
        public WorkerService(DBContext context)
        {
            _context = context;
        }   

        public void Add(Worker ticket)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Worker> GetAll()
        {
            var result = _context.Workers.ToList();
            return result;
        }

        public Worker GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public Worker Update(int id, Worker newTicket)
        {
            throw new NotImplementedException();
        }
    }
}
