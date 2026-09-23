using AdvenNewWebsite.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HizmetlerController : Controller
    {
        HizmetlerManager hizmetlerManager = new HizmetlerManager(new EFHizmetlerDAL());
        public IActionResult Index()
        {
            var values = hizmetlerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult HizmetEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HizmetEkle(HizmetModel h)
        {
            Hizmetler hizmet = new Hizmetler();
            if (h.ResimUpload != null)
            {
                var extension = Path.GetExtension(h.ResimUpload.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Hizmetler", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                h.ResimUpload.CopyTo(stream);
                hizmet.Foto = newimagename;
            }

            hizmet.HizmetAdi = h.HizmetAdi;
            hizmet.Aciklama = h.Aciklama;
            hizmet.Anasayfa = h.Anasayfa;
            hizmet.EklemeTarihi = DateTime.Now;
            hizmet.AktifMi = true;

            hizmetlerManager.TAdd(hizmet);
            return LocalRedirect("/Admin/Hizmetler/Index");
        }

        [HttpGet]
        public IActionResult HizmetGuncelle(int id)
        {
            var values = hizmetlerManager.TGetByID(id);
            ViewBag.Resim = values.Foto;
            ViewBag.Adi = values.HizmetAdi;
            return View(values);
        }

        [HttpPost]
        public IActionResult HizmetGuncelle(HizmetModel h, IFormFile picture)
        {
            var hizmet = hizmetlerManager.TGetByID(h.HizmetID);
            if (picture != null)
            {
                var extension = Path.GetExtension(picture.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Hizmetler", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                picture.CopyTo(stream);
                hizmet.Foto = newimagename;
            }

            hizmet.HizmetAdi = h.HizmetAdi;
            hizmet.Aciklama = h.Aciklama;
            hizmet.Anasayfa = h.Anasayfa;
            hizmet.EklemeTarihi = DateTime.Now;
            hizmet.AktifMi = h.AktifMi;

            hizmetlerManager.TUpdate(hizmet);
            return LocalRedirect("/Admin/Hizmetler/Index");
        }

        public IActionResult HizmetSil(int id)
        {
            var values = hizmetlerManager.TGetByID(id);
            hizmetlerManager.TDelete(values);

            var hizmetFoto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Hizmetler", values.Foto);

            return LocalRedirect("/Admin/Hizmetler/Index");
        }
    }
}
