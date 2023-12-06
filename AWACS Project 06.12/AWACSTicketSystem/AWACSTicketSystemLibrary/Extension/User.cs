using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWACSTicketSystemLibrary
{
    public partial class User

//attributes with validation which we will use in the constructor further on

    {
        private string _workerID;
        public string WorkerID
        {
            get { return _workerID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A worker ID is required");
                _workerID = value;
            }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Invalid name");
                _name = value;
            }  
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Invalid name");
                _surname = value;
            }
        }

        private List<Ticket> _created = new List<Ticket>();
        public List<Ticket> Created
        {
            get { return _created; }
            set
            {
                if (value == null)
                    throw new Exception("Every ticket must have a creator");
                _created = value;
            }
        }

        private List<Ticket> _responsible = new List<Ticket>();
        public List<Ticket> Responsible
        {
            get { return _responsible; }
            set
            {
                if (value == null)
                    throw new Exception("Every ticket must have at least one responsible");
                _responsible = value;
            }
        }

//two simple properties inside the class

        public string Department { get; set; }
        public string Email { get; set; }

//a constructor is used to stablish the parameters we want whenever a new object is created
//I guess, that is the reason why we make it private, because it will be accessed through the constructor 

        public User(string WorkerID, string Name, string Surname)
        {
            _workerID = WorkerID;
            _name = Name;
            _surname = Surname;
        }
    }
}
