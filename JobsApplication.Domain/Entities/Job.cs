using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Domain.Entities
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsClosed { get; set; }
        public DateTime? ClosedAt { get; set; }

    

        [ForeignKey(nameof(Recruiter))]
        public Guid RecruiterId { get; set; }
        public Recruiter Recruiter { get; set; }

    }
}
