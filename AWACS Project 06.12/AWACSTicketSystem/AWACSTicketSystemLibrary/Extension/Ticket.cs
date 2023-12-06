using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWACSTicketSystemLibrary
{
    public partial class Ticket
    {
        private string _ticketID;
        public string TicketID
        {
            get { return _ticketID; }
            set
            {
                if (value == null)
                    throw new Exception("A valid ticket ID number is required");
                _ticketID = value;
            }
        }
        private string _category;
        public string Category
        {
            get { return _category; }
            set
            {
                if (value == null) throw new Exception("A category for this ticket is required");
                _category = value;
            }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (value == null) throw new Exception("A description for this ticket is required");
                _description = value;
            }
        }

//simple properties

        public string Solution { get; set; }
        public string DateObserved { get; set; }
        public string PlannedEndDate { get; set; }
        public string Status { get; set; }
        public string Progress { get; set; }

//the constructor for the class ticket is built

        public Ticket(string TicketID, string Category, string Description)
        {
            _category = Category;
            _ticketID = TicketID;
            _description = Description;
        }

//converting the code into methods

        public string getTicketDescription()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Description);

            bool first = true;
            foreach (var Ticket in User.Responsible) 

            {


            }



        }
           
       
    }

}

