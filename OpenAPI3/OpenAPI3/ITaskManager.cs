using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestfulDomain;


namespace OpenAPI3
{
    public interface ITaskManager
    {
        ITaskStatus requestSecurity(SecurityRequest srp);
        SecurityResponse respondSecurity();
    }
}
