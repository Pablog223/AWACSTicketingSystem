using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWACSTicketLibrary
{
    public class User
    {
        public int WorkerID { get; set; }

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
        
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }

    }
}
