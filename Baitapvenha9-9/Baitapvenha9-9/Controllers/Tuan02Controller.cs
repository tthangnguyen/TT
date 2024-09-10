using Microsoft.AspNetCore.Mvc;

namespace baitapvenha9_9.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Đức Thắng";
            ViewBag.MSSV = "1822040966";
            ViewData["Nam"] = "Năm 2004";
            return View();
        }
    }
}
