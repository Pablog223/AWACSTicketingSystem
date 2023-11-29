using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWACSTicketLibrary
{
    public class Ticket
    {
        private User _responsible;
        public User Responsible
        {
            get { return _responsible; }
            set
            {
                if (value == null)
                    throw new Exception("Every ticket must have a responsible");
                _responsible = value;
            }
        }
                    
        private User _creator;
        public User Creator
        {
            get { return _creator; }
            set
            {
                if (value == null)
                    throw new Exception("Every ticket must have a creator");
                _creator = value;
            }
        }
        private string _id;
        public string ID 
        { 
            get {  return _id; }
            set
            {
                if (value == null)
                    throw new Exception("A valid ticket ID number is required");
                _id = value;
            }               
        }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Solution { get; set; }
        public string DateObserved { get; set; }
        public string PlannedEndDate { get; set; }
        public string Status { get; set; }
        public string Progress { get; set; }
    }
}

