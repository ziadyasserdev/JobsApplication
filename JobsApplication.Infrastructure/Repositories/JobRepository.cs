using JobsApplication.Application.Abstractions;
using JobsApplication.Domain.Entities;
using JobsApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Infrastructure.Repositories
{
    public class JobRepository : IJopRepository
    {
        private readonly ApplicationDbContext context;

        public JobRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddJobAsync(Job job)
        {
            await context.Jobs.AddAsync(job);
            await context.SaveChangesAsync();
        }

        public async Task<Job?> GetJobByIdAsync(int jobId)
        {
            return await context.Jobs.FindAsync(jobId);
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await context.Jobs.ToListAsync();
        }

        public async Task UpdateJobAsync(Job job)
        {
            context.Jobs.Update(job);
            await context.SaveChangesAsync();
        }

        public async Task CloseJob(Guid jobId)
        {
            var job = await context.Jobs.FirstOrDefaultAsync(j => j.Id == jobId) ??
                throw new InvalidOperationException($"Job with ID {jobId} not found.");

            job.IsClosed = true;
            await context.SaveChangesAsync();
        }

        public async Task DeleteJobAsync(int jobId)
        {
            var job = await context.Jobs.FindAsync(jobId);
            if (job != null)
            {
                context.Jobs.Remove(job);
                await context.SaveChangesAsync();
            }
        }
    }
}
