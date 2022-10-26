using Microsoft.AspNetCore.Mvc;
using SimpleMVCExamples.Models;

namespace SimpleMVCExamples.Controllers
{
    public class ArabaKisiController : Controller
    {
        public IActionResult Index()
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Tolga";
            kisi.Soyad = "Erçin";
            Araba araba = new Araba();
            araba.Marka = "Porsche";
            araba.Model = "911";
            ArabaKisiVM arabaKisiVM = new ArabaKisiVM();
            arabaKisiVM.KisiAd = kisi.Ad;
            arabaKisiVM.KisiSoyad = kisi.Soyad;
            arabaKisiVM.ArabaMarka = araba.Marka;
            arabaKisiVM.ArabaModel = araba.Model;



          

            return View(arabaKisiVM);
        }

       
    }
}
