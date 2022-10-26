using Microsoft.AspNetCore.Mvc;
using SimpleMVCExamples.Models;
using System.Diagnostics;

namespace SimpleMVCExamples.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Contact2()
        {
           
            ViewData["adres"] = "Ankara/Yenimahalle";
            ViewBag.telefon = "123456789";
            return View();
        }

       
      

        //Index sayfasında adınız soyadınız birer html tagi içinde yazdırınız.
        ////1 tane contact2 adında action oluşturunuz.Bu actiona ulaştığımda ekranda merhaba yazsın.
        //1 tane contact2 adında action oluşturunuz.adres ve telefon bilginizi string değişkenler içinde tutup ekrana yazdırmaya çalışınız.
        //Araba  controller oluşturunuz. içerisinde bmw audi ve index actionlarını bulundursun.İndex sayfasında merhaba ben index sayfasıyım yazsın.
        //bmw viewına nesne ile bmw yazısı gönderelim(html h1 tagi içine)
        //audi viewına nesne ile audi yazısı gönderelim(html h1 tagi içine)

        //KisiController. Ali , Veli string.
        //Ahmet IAction return Content.
        //Mehmet return view.



    }
}