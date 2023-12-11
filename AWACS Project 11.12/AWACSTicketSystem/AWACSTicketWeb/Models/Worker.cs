using AWACSTicketSystemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AWACSTicketSystemWeb.Models
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "WorkerID")]
        public int WorkerID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }

        //Relathionships
        public List<Ticket> ResponsibleWorkers { get; set; }

        public List<Ticket> CreatorWorker { get; set; }

        //Worker
        public int WorkerId { get; set; }
        [ForeignKey("WorkerId")]
        public Worker worker {  get; set; }
    }
}