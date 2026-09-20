using JobsApplication.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Domain.Entities
{
    public class JobCandidateApplication
    {
        public Guid Id { get; set; }
        public ApplicationStatus ApplicationStatus { get; set; }
        public DateTime AppliedAt { get; set; }


        [ForeignKey(nameof(Candidate))]
        public Guid CandidateID { get; set; }
        [ForeignKey(nameof(Job))]
        public Guid JobId { get; set; }
        public Job Job { get; set; }
        public Candidate Candidate { get; set; }
    }
}
