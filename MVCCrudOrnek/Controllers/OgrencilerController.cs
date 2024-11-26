using Microsoft.AspNetCore.Mvc;
using MVCCrudOrnek.Models;

namespace MVCCrudOrnek.Controllers
{
    public class OgrencilerController : Controller
    {

        public IActionResult Index()
        {
            var ogrenciler = Veri.Ogrenciler;

            return View(ogrenciler);
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(YeniOgrenciViewModel ogrenci)
        {
            // VERİLERİN GEÇERLİLİĞİNİ KONTROL ET
            if (ModelState.IsValid)
            {
                // VERİLER GEÇERLİ İSE ÖĞRENCİYİ KAYDET VE ÖĞRENCİ LİSTESİNE YÖNLEN
                Ogrenci yeni = new Ogrenci()
                {
                    Id = Veri.Ogrenciler.Max(o => o.Id) + 1,
                    Ad = ogrenci.Ad,
                    DogumYili = ogrenci.DogumYili.Value,
                    Takim = ogrenci.Takim
                };
                Veri.Ogrenciler.Add(yeni);

                // Bu controller'ın Index adındaki action'ına tarayıcıyı yönlendir
                return RedirectToAction("Index");
            }

            // VERİLER GEÇERLİ DEĞİLSE AYNI SAYFAYI TEKRAR GÖSTER
            return View();
        }
    }
}
