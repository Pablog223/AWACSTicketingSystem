using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AWACSTicketSystemWeb.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int WorkerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }

    }
}