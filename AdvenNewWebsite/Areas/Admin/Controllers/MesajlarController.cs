using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MesajlarController : Controller
    {
        MesajlarManager mesajlarManager=new MesajlarManager(new EFMesajlarDAL());
        public IActionResult Index()
        {
            var values = mesajlarManager.TGetList();
            return View(values);
        }
    }
}
