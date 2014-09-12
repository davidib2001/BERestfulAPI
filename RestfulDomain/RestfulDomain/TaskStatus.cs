using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulDomain
{
    public class TaskStatus : ITaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public TASKSTATUS Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ERRORCODES ErrorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public uint Id { get; set; }
    }
}
