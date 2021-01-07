
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        /***************************** testing controllers and views******************
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        //
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web; 
        public string Welcome(string name, int ID = 1)
        {
            //Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript)
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        ***************************************************************************/
    }
}