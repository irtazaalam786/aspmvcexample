using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ASPMVCCRUD.Models;

namespace ASPMVCCRUD.Models
{
    public class ASPContext : DbContext
    {
        //Entities
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}