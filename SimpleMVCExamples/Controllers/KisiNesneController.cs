using Microsoft.AspNetCore.Mvc;
using SimpleMVCExamples.Models;

namespace SimpleMVCExamples.Controllers
{
    public class KisiNesneController : Controller
    {
        private List<Kisi> kisiler;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Naber()
        {
            Kisi yeniKisi = new Kisi();
            yeniKisi.Ad = "Oğuzhan";
            yeniKisi.Soyad = "Bayram";
            Kisi eskiKisi = new Kisi();
            eskiKisi.Ad = "123";
            eskiKisi.Soyad = "456";

            ViewData["Ad"] = eskiKisi.Ad;
            ViewBag.Soyad = eskiKisi.Soyad;
            TempData["lorem"] = "";

            return View(yeniKisi);
            
        }

        public IActionResult ListeDon()
        {
            Kisi yeniKisi = new Kisi();
            yeniKisi.Ad = "Oğuzhan";
            yeniKisi.Soyad = "Bayram";

            Kisi eskiKisi = new Kisi();
            eskiKisi.Ad = "123";
            eskiKisi.Soyad = "456";

            Kisi Kisi1 = new Kisi();
            Kisi1.Ad = "Oğuzhan1";
            Kisi1.Soyad = "Bayram1"; 

            Kisi Kisi2 = new Kisi();
            Kisi2.Ad = "Oğuzhan2";
            Kisi2.Soyad = "Bayram2"; 

            Kisi Kisi3 = new Kisi();
            Kisi3.Ad = "Oğuzhan3";
            Kisi3.Soyad = "Bayram3";
           
            kisiler = new List<Kisi>();
            kisiler.Add(yeniKisi);
            kisiler.Add(eskiKisi);
            kisiler.Add(Kisi1);
            kisiler.Add(Kisi2);
            kisiler.Add(Kisi3);
            ViewData["Kisiler"] = kisiler;
            ViewBag.elemanSayisi = kisiler.Count();
            ViewBag.sonElemanAd = kisiler.Last().Ad;
            ViewBag.sonElemanSoyad = kisiler.Last().Soyad;
            ViewBag.ilkEleman = kisiler.First();
            
            return View(kisiler);
        }
        //Naber action. 1 tane  kişi class. 2 prop ad soyad. 
        //ad soyad viewda ekrana yazdırınız. h1 -p
        //başka bir controller. viewbag viewdata ile aynı bilgileri gönderiniz.

        //yeni action . Kisi listesi oluşturunuz. Listenin elemanlarını ekrana yazdırınız.
        //@model kullanmadan
        //kişi listesinin eleman sayısını yazdırınız.
        //kişi listesinin ilk elemanını yazdırınız.
        //TEMPDATA

        //Tablo oluşturunuz viewda gösteriniz.
    }
}
