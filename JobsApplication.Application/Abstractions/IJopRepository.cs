using JobsApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Application.Abstractions
{
    public  interface IJopRepository
    {
        Task AddJobAsync(Job job);
        Task<Job?> GetJobByIdAsync(int jobId);
        Task<IEnumerable<Job>> GetAllJobsAsync();
        Task UpdateJobAsync(Job job);
        Task CloseJob(Guid jobId);
        Task DeleteJobAsync(int jobId);
    }
}
