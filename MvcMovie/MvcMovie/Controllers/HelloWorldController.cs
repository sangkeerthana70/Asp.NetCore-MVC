using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        // parameter format HelloWorld/Welcome?name=anu&numTimes=4
        //public string Welcome(string name, int numTimes = 1)
        //{
        //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}
        // 
        // GET: /HelloWorld/Welcome/ 
        //parameter format /HelloWorld/Welcome/3?name=anu
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        
    }
}
