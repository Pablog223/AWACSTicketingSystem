using AWACSTicketSystemLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AWACSTicketingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

//list of user names, using the constructor user

            User Max = new User("3878", "Max", "Mustermann");
            User Marie = new User("3978", "Marie", "Waltz");
            User Jonas = new User("3872", "Jonas", "Perez");
            User Enrique = new User("3863", "Enrique", "Scholz");
            User Mario = new User("3868", "Mario", "Götze");
            User Marco = new User("3859", "Marco", "Müller");

//list of ticket names, using the constructor ticket, based of IDNumber, category and creator name

            Ticket Q24 =new Ticket("24", "Quality", "tablets for the workers");
            Ticket C9 = new Ticket("9", "Cost", "hours not counted");
            Ticket S37 = new Ticket("37", "Safety", "oil leak under the plane");
            Ticket Q21 = new Ticket("21", "Quality", "materials used after their expiration date");
            Ticket S18 = new Ticket("18", "Safety", "FODs in the middle of the hangar");

//assignment of responsibles per ticket to the list

            Max.Created.Add(Q24);
            Marie.Created.Add(S37);
            Jonas.Created.Add(C9);
            Max.Created.Add(Q21);
            Marco.Created.Add(S18);

//assignment of responsibles per ticket to the list

            Max.Responsible.Add(Q24);
            Marie.Responsible.Add(Q24);
            Jonas.Responsible.Add(C9);
            Max.Responsible.Add(S37);
            Marco.Responsible.Add(S37);

            Console.Write(Max.Name + " ");
            Console.Write(Max.Surname + " ");
            Console.Write("with Worker ID " + Max.WorkerID);

            bool first = true;
            foreach (var Ticket in Max.Created)
            {
                if (first)
                {
                    Console.Write(" created the ticket with TicketID ");
                    first = false;
                }
                
                else
                {
                    Console.Write(" and the ticket ");
                }

                Console.Write(Ticket.TicketID);
               
            }

            bool firstagain = true;
            foreach (var Ticket in Max.Responsible)
            {
                if (firstagain)
                {
                    Console.Write(" He is also responsible for the ticket ");
                    firstagain = false;
                }
                else
                {
                    Console.Write(" and ticket ");
                }

                Console.Write(Ticket.TicketID);
            }
        }
    }
}
