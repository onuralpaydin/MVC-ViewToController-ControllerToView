using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCExamples.Controllers
{
    public class KisiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Ali()
        {

            return "Merhaba ben ali";
        }

        public string Veli()
        {
            return "Merhaba ben Veli. Bu soruyu Sefa yaptı";
        }

        public IActionResult Ahmet()
        {
            return Content("<h1>Ben Ahmet</h1>","text/html; charset=UTF-8");
        }


        public IActionResult Mehmet()
        {
            ViewBag.Mehmet = "Merhaba ben Mehmet. Bunu tolga s. yazdırdı";
            ViewData["Mehmet"] = "Merhaba ben Mehmet. Bunu tolga s. yazdırdı"; 
            return View();
        }

       
    }
}
