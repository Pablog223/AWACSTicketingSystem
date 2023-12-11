using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AWACSTicketSystemWeb.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<LoginViewModel> LoginView { get; set; }

    }
}