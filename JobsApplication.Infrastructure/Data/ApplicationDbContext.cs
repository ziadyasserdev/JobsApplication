using JobsApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCandidateApplication> JobApplications { get; set; }

    }
}
