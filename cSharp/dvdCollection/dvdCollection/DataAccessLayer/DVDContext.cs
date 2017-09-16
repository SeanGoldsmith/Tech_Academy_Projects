using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dvdCollection.DataAccessLayer
{
    public class DVDContext : DbContext
    {
        public DVDContext() : base("movieDb")
        {

        }

        public DbSet<dvdCollection.Models.dvd> dvd { get; set; }

    }
}