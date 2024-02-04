using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWACSTicketLibrary
{
    public partial class Worker
    {
        public override string ToString()
        {
            return $"{Name} {Surname} with the Worker Identification {WorkerId}";
        }
        public string AsString => ToString();
    }
    public partial class Ticket
    {
        public override string ToString()
        {
            return $"This is the Ticket {TicketId} created by {Creator} and with the responsible {Responsible}";
        }
        public string AsString => ToString();
    }

}
