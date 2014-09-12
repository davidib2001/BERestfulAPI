using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace RestfulDomain
{
    public class SecurityResponse : BaseResponse
    {
        //<todo> make this an interface so we don't have to implement set
        //public List<CalculateSecurity> Data { get; set; }
        public List<SecurityMeasure> Data { get; set; }
    }
}
