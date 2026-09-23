using AdvenNewWebsite.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReferanslarController : Controller
    {
        ReferanslarManager referanslarManager=new ReferanslarManager(new EFReferanslarDAL());
        public IActionResult Index()
        {
            var values=referanslarManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ReferansEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReferansEkle(ReferansModel r)
        {
            Referanslar referans = new Referanslar();
            if (r.ResimUpload != null)
            {
                var extension = Path.GetExtension(r.ResimUpload.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Referanslar", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                r.ResimUpload.CopyTo(stream);
                referans.ReferansLogo = newimagename;
            }

            referans.ReferansAdi = r.ReferansAdi;
            referans.AktifMi = true;

            referanslarManager.TAdd(referans);
            return LocalRedirect("/Admin/Referanslar/Index");
        }

        [HttpGet]
        public IActionResult ReferansGuncelle(int id)
        {
            var values = referanslarManager.TGetByID(id);
            ViewBag.Resim = values.ReferansLogo;
            ViewBag.Adi = values.ReferansAdi;
            return View(values);
        }

        [HttpPost]
        public IActionResult ReferansGuncelle(ReferansModel r, IFormFile picture)
        {
            var referans = referanslarManager.TGetByID(r.ReferansID);
            if (picture != null)
            {
                var extension = Path.GetExtension(picture.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Referanslar", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                picture.CopyTo(stream);
                referans.ReferansLogo = newimagename;
            }

            referans.ReferansAdi = r.ReferansAdi;
            referans.AktifMi = r.AktifMi;

            referanslarManager.TUpdate(referans);
            return LocalRedirect("/Admin/Referanslar/Index");
        }

        public IActionResult ReferansSil(int id)
        {
            var values = referanslarManager.TGetByID(id);
            referanslarManager.TDelete(values);

            var referansFoto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Referanslar", values.ReferansLogo);

            return LocalRedirect("/Admin/Referanslar/Index");
        }
    }
}
