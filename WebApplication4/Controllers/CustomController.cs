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



        // Hakkımızda action'ı (GET)
        [HttpGet]
        public IActionResult Hakkimizda()
        {
            return View("~/Views/Custom/hakkımızda.cshtml");
        }

    }
}
    