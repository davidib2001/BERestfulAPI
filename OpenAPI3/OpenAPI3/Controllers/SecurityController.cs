using System.Threading.Tasks;
using System.Web.Http;
using System.Web;
using System.Net.Http;
using System.Text;
using System.Net;
using RestfulDomain;



namespace OpenAPI3.Controllers
{
public class SecurityController : ApiController
{
    private readonly ITaskManager _taskManager;
    public SecurityController()
    {

        int rr = 999;
        
    }

    public SecurityController(ITaskManager tm)
    {
        _taskManager = tm;
    }

#if false
    [HttpGet]
    [ActionName("GetSecurity")]
    public SecurityResponse GetSecurity([FromBody]SecurityRequest security)
    {
        SecurityResponse tmp = new SecurityResponse();
        tmp.SetUser("kyu");
        return tmp;
    }
#endif
    [HttpPost]
    [ActionName("PostSecurity")]
    public async Task<ITaskStatus> PostSecurity([FromBody]SecurityRequest srp)
    {
        string userName = this.User.Identity.Name;
        return await Task.Factory.StartNew(() => _taskManager.requestSecurity(srp));
    }

    [HttpGet]
    [ActionName("GetSecurity")]
    public async Task<SecurityResponse> GetSecurity()
    {
        return await Task.Factory.StartNew(() => _taskManager.respondSecurity());
    }


}
}
