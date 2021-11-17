using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace tutorialAsp.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
         
        // /HelloWorld/Welcome?name=Rick&numtimes=10 ponemos esto para buscar y darles valores
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public string Saludos(int? id)
        {
            return "Hola... de nuevo "+id;
        }
    }
}