using AWACSTicketSystemLibrary;
using AWACSTicketSystemWeb.Models;

namespace AWACSTicketWeb.Data.Functions
{
    public interface IWorkerService
    {
        IEnumerable<Worker> GetAll();

        Worker GetByID(string id);

        void Add (Worker ticket);

        Worker Update(int id, Worker newTicket);

        void Delete(int id);

    }
}
