using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        //public string Index()
        //{
        //    return "HelloWorld Index String return";
        //}

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //public string Welcome(string name, int ID = 1) {
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID is: " + ID);
        //}

        public ActionResult Welcome(string name, int numTimes = 2)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;


            return View();
        }
    }
}