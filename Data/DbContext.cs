using Interview2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }

        public ApplicationDbContext() : base("StudentDBContext")
        {
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}