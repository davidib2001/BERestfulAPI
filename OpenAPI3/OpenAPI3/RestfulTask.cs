using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenAPI3
{
    public enum restfulTaskStatus
    {
        success = 0,
        error = 1,
    }

    public class RestfulTask
    {
        public restfulTaskStatus status;
        public string msg;
    }
}