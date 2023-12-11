using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using AWACSTicketWeb.Models;
using AWACSTicketSystemWeb.Models;
using AWACSTicketSystemLibrary;

namespace AWACSTicketSystemWeb.Data
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) 
        { 
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}