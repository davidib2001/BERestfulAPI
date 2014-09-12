using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace RestfulDomain
{
    public class SecurityRequest : BaseRequest
    {
        public List<SecurityInfo> Securities;
        public List<Domain.Enums.FieldCodes> FieldCodes;
    }
}
