using Baitapvenha9_9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baitapvenha9_9.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "nguyễn Đức Thắng";
            ViewBag.MSSV = "1822040919";
            ViewData["Nam"] = "Năm 2004";
            return View();
        }


    }

}