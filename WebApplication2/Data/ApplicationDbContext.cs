using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DegreeCredit> DegreeCredits { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<StudentTerm> StudentTerms { get; set; }

    }
}
