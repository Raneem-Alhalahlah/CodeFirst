using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codeFirst_Task1.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Assignment> assignments { get; set; }

    }
}

