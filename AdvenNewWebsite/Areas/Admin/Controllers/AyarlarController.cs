using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AyarlarController : Controller
    {
        AyarlarManager ayarlarManager = new AyarlarManager(new EFAyarlarDAL());
        public IActionResult Index()
        {
            var values = ayarlarManager.TGetList();
            return View(values);
        }
    }
}
