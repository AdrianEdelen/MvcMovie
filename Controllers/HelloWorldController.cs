using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //get /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        //get /HelloWorld/Welcome/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}