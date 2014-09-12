using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulDomain
{
    public interface IResponse 
    {
        //Guid GetID();
        //void SetID(Guid id);
        //String GetUser();
        //void SetUser(String user);
        //RestfulDomain.ERRORCODES GetReturnCode();
        //void SetReturnCode(ERRORCODES returnCode);
        Guid ID { get; set; }
        String User {get;set;}

    }
}
