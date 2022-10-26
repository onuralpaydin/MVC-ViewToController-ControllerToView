using Microsoft.AspNetCore.Mvc;

namespace SimpleMVCExamples.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BMW()
        {
            ViewBag.Bmw = "Ben BMW YİM";
            return View();
        }

        public IActionResult Audi()
        {
            ViewData["Marka"] = "Audi";
            ViewData["Model"] = "Q7";
            return View();
        }
    }
}
