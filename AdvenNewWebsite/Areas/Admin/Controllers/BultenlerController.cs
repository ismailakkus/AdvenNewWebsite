using AdvenNewWebsite.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BultenlerController : Controller
    {
        BultenlerManager bultenlerManager = new BultenlerManager(new EFBultenlerDAL());
        public IActionResult Index()
        {
            var values = bultenlerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult BultenEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BultenEkle(BultenModel b)
        {
            Bultenler bulten = new Bultenler();

            bulten.MailAdresi = b.MailAdresi;
            bultenlerManager.TAdd(bulten);
            return LocalRedirect("/Admin/Bultenler/Index");
        }

        public IActionResult BultenSil(int id)
        {
            var values = bultenlerManager.TGetByID(id);
            bultenlerManager.TDelete(values);
            return LocalRedirect("/Admin/Bultenler/Index");
        }

    }
}
