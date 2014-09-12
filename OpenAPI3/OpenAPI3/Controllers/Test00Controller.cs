using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenAPI3.Controllers
{
    public class Test00Controller : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int id)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + id);
        } 
    }
}