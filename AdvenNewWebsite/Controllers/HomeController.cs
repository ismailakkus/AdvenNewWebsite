using System.Diagnostics;
using AdvenNewWebsite.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Controllers
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

        BultenlerManager bultenlerManager = new BultenlerManager(new EFBultenlerDAL());
        [HttpGet]
        public PartialViewResult BultenEkle()
        {

            return PartialView();
        }

        [HttpPost]
        public PartialViewResult BultenEkle(Bultenler b)
        {
            bultenlerManager.TAdd(b);
            RedirectToAction("Index", "Home");
            return PartialView();
        }
    }
}
