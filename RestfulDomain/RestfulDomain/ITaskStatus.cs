using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulDomain
{
    public interface ITaskStatus
    {
        TASKSTATUS Status { get; set; }
        String Message { get; set; }
        ERRORCODES ErrorCode { get; set; }
    }
}
