using System.Threading.Tasks;
using System.Web.Http;
using System.Web;
using System.Net.Http;
using System.Text;
using System.Net;




namespace OpenAPI3.Controllers
{
public class TestsController : ApiController
{
    public TestsController()
    {
        int rr = 999;
    }

    [HttpGet]
    [ActionName("ping")]
    public HttpResponseMessage ping()
    {
        return new HttpResponseMessage() { Content = new StringContent("pong from "+Dns.GetHostName(), Encoding.UTF8, "text/html") };
    }


}
}
