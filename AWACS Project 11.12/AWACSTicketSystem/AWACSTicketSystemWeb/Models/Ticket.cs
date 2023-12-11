using AWACSTicketSystemWeb.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWACSTicketSystemLibrary
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public string TicketID { get; set; }
        public TicketCategory Category { get; set; }
        public string Description { get; set; } 
        public string Solution { get; set; }
        public DateTime DateObserved { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public string Status { get; set; }
        public string Progress { get; set; }

    }

}

