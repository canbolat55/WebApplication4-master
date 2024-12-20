using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApplication4.Controllers
{
    public class Custom : Controller
    {
        // Homepage action'ı
        public IActionResult Homepage()
        {
            return View(); // Bu action, Homepage.cshtml sayfasını döndürür
        }
        public IActionResult Hakkimizda()
        {
            return View(); // Varsayılan olarak Views/Custom/hakkimizda.cshtml dosyasını arar
        }


        public ActionResult Listele(string fromCity, string toCity, string journeyDate)
{
    // Parametrelerle ilgili işlemleri burada yapabilirsiniz.
    // Örnek: Veritabanından uygun biletleri listeleme
    ViewBag.FromCity = fromCity;
    ViewBag.ToCity = toCity;
    ViewBag.JourneyDate = journeyDate;

    return View();
}
        [HttpPost]
        public IActionResult ListeOtel(string hotelCity, string checkInDate, string checkOutDate)
        {
            
            return View();
        }
        public IActionResult SatinAl(int ticketId, string seats)
        {
            // 'seats' parametresini kontrol ediyoruz.
            if (string.IsNullOrEmpty(seats))
            {
                ViewData["message"] = "Henüz bir koltuk seçmediniz.";
            }
            else
            {
                ViewData["message"] = $"Seçilen Koltuklar: {seats}";
            }

            return View();
        }

    }
}
    