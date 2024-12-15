using Microsoft.AspNetCore.Mvc;

namespace YourApp.Controllers
{
    public class HotelReservationController : Controller
    {
        // Formun Görüntüleneceği GET Action Yöntemi
        [HttpGet]
        public IActionResult CreateReservation()
        {
            return View();
        }

        // Form Verilerinin Gönderileceği ve İşleneceği POST Action Yöntemi
        [HttpPost]
        public IActionResult CreateReservation(string hotelName, DateTime checkInDate, DateTime checkOutDate, int numberOfGuests)
        {
            // Verileri işleme (örneğin: veritabanına kaydetme)
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Rezervasyon başarıyla oluşturuldu!";
                return RedirectToAction("ReservationSuccess");
            }
            else
            {
                // Geçersiz form, formu yeniden göster ve hata mesajlarını döndür
                return View();
            }
        }

        // Başarılı rezervasyon sonrası sayfa
        public IActionResult ReservationSuccess()
        {
            return View();
        }
    }
}
