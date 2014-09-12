using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulDomain
{
    public class BaseRequest : IRequest
    {
        public Guid ID;
        public String User;
        public Guid GetID() { return ID; }
        public void SetID(Guid id) { ID = id; }
        public String GetUser() { return User; }
        public void SetUser(String user) { User = user; }
    }
}
