using System.Threading.Tasks;
using System.Web.Http;
using System.Web;
using System.Net.Http;
using System.Text;
using System.Net;
using Domain;



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
#if false
    [HttpPost]
    [ActionName("PostSecurityAnalysis")]
    public async Task<ITaskStatus> postSecurityAnalysis([FromBody]SecurityRequest srp)
    {
        string userName = this.User.Identity.Name;
        return await Task.Factory.StartNew(() => _taskManager.requestSecurity(srp));
    }

    [HttpGet]
    [ActionName("GetSecurityAnalysis")]
    public async Task<SecurityResponse> getSecurityAnalysis()
    {
        return await Task.Factory.StartNew(() => _taskManager.respondSecurity());
    }
#endif

    [HttpPost]
    [ActionName("PostSecurityOASAnalysis")]
    public async Task<RestfulTask> postSecurityOASAnalysis([FromBody]SecurityOASAnalysisRequest srp)
    {
        return await Task.Factory.StartNew(() => _taskManager.requestSecurityOASAnalysis(srp));
    }

    [HttpGet]
    [ActionName("GetSecurityOASAnalysis")]
    public async Task<SecurityOASAnalysisResponse> getSecurityOASAnalysis()
    {
        return await Task.Factory.StartNew(() => _taskManager.respondSecurityOASAnalysis());
    }

    [HttpPost]
    [ActionName("PostSecurityAnalyticalOutput")]
    public async Task<RestfulTask> postSecurityAnalyticalOutput([FromBody]SecurityAnalyticalMeasureRequest srp)
    {
        return await Task.Factory.StartNew(() => _taskManager.requestSecurityAnalyticalOutput(srp));
    }

    [HttpGet]
    [ActionName("GetSecurityAnalyticalOutput")]
    public async Task<SecurityAnalyticalMeasureResponse> getSecurityAnalyticalOutput()
    {
        return await Task.Factory.StartNew(() => _taskManager.respondSecurityAnalyticalOutput());
    }

    [HttpPost]
    [ActionName("PostSecurityStaticCashFlow")]
    public async Task<RestfulTask> postSecurityStaticCashFlow([FromBody]SecurityCashFlowRequest srp)
    {

        return await Task.Factory.StartNew(() => _taskManager.requestSecurityStaticCashFlow(srp));
    }

    [HttpGet]
    [ActionName("GetSecurityStaticCashFlow")]
    public async Task<SecurityCashFlowResponse> getSecurityStaticCashFlow()
    {
        return await Task.Factory.StartNew(() => _taskManager.respondSecurityStaticCashFlow());
    }
}
}
