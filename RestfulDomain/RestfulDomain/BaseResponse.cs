using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace RestfulDomain
{
    public class BaseResponse : IResponse, ITaskStatus
    {
        public TASKSTATUS Status{get;set;}
        public String Message {get;set;}
        public ERRORCODES ErrorCode { get; set; }
        public Guid ID { get; set; }
        public String User { get; set; }

#if false
        public Guid ID;
        public String User;
        public ERRORCODES ReturnCode;
        public Guid GetID() { return ID; }
        public void SetID(Guid id) { ID = id; }
        public string GetUser() { return User; }
        public void SetUser(String user) { User = user; }
        public ERRORCODES GetReturnCode() { return ReturnCode; }
        public void SetReturnCode(ERRORCODES returnCode) { ReturnCode = returnCode; }
#endif
    }
}
