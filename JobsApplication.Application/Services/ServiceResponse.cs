using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsApplication.Application.Services
{
    public class ServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
