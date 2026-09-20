using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Application.Dtos
{
    public class CreateJobDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
