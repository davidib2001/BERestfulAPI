using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulDomain
{
public interface IRequest
{
    Guid GetID();
    void SetID(Guid id);
    String GetUser();
    void SetUser(String user);
}
}
