using System.Threading.Tasks;
using System.Web.Http;
using System.Web;
using System.Net.Http;
using System.Text;
using System.Net;
using RestfulDomain;



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



    [HttpGet]
    [ActionName("getPingForBrowser")]
    public HttpResponseMessage GetPongNoPing()
    {
        return new HttpResponseMessage() { Content = new StringContent("<strong>pong from " + Dns.GetHostName() + "</strong>", Encoding.UTF8, "text/html") };
    }


    [HttpGet]
    [ActionName("getSimpleDataTest")]
    public SimpleData getSimpleDataTest(int id)
    {
        SimpleData tmp = new SimpleData { id = 100, name = "kyu" };
        return tmp;
    }

    [HttpPost]
        [ActionName("postSimpleDataTest")]
        public int postSimpleDataTest([FromBody]SimpleData tasks)
        {
            int i = 999;
            return i;
        }

}
}
