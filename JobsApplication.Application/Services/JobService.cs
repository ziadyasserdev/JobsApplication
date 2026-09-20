using JobsApplication.Application.Abstractions;
using JobsApplication.Application.Dtos;
using JobsApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Application.Services
{
    public class JobService
    {
        private readonly IJopRepository jobRepository;

        public JobService(IJopRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        public async Task<ServiceResponse<JobDto>> CreateJobAsync(CreateJobDto createJobDto, Guid userId)
        {
         

            var job = new Job
            {
                Id = Guid.NewGuid(),
                Title = createJobDto.Title,
                Description = createJobDto.Description,
                IsActive = createJobDto.IsActive,
            };

            await jobRepository.AddJobAsync(job);

            var jobdto = new JobDto
            {
                Id = job.Id,
                Title = job.Title,
                Description = job.Description,
                IsActive = job.IsActive,
                IsClosed = job.IsClosed,
                ClosedAt = job.ClosedAt
            };

            return new ServiceResponse<JobDto>
            {
                IsSuccess = true,
                Message = "Job created successfully.",
                Result = jobdto
            };
        }

        public async Task<ServiceResponse<bool>> CloseJob(Guid jobId, Guid userId)
        {
            //Validation would be here when identity and roles are implemented.


            await jobRepository.CloseJob(jobId);

            return new()
            {
                IsSuccess = true,
                Message = "Job closed successfully.",
                Result = true
            };
        }
    }
}
