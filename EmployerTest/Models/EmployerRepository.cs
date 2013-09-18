using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployerTest.Models
{
    public class EmployerRepository
    {
        private EFDbContext context;

        public EmployerRepository()
        {
            context = new EFDbContext();
        }

        public IQueryable<Employer> Employers { get { return context.Employer; } }

        public void AddEmployer(Employer employer)
        {
            context.Employer.Add(employer);
            context.SaveChanges();
        }

        public void SaveEmployer(Employer employer)
        {
            context.Entry(employer).State = System.Data.EntityState.Modified;
            context.SaveChanges();
        }

        public void RemoveEmployer(Employer employer)
        {
            context.Employer.Remove(employer);
            context.SaveChanges();
        }
    }

    public class EFDbContext : DbContext
    {
        public DbSet<Employer> Employer { get; set; }
    }
}