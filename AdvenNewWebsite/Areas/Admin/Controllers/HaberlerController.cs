using AdvenNewWebsite.Areas.Admin.Models;
using AdvenNewWebsite.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HaberlerController : Controller
    {
        HaberlerManager haberlerManager = new HaberlerManager(new EFHaberlerDAL());
        public IActionResult Index()
        {
            var values = haberlerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult HaberEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HaberEkle(HaberModel h)
        {
            Haberler haber = new Haberler();
            if (h.ResimUpload != null)
            {
                var extension = Path.GetExtension(h.ResimUpload.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Haberler", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                h.ResimUpload.CopyTo(stream);
                haber.HaberFoto = newimagename;
            }

            haber.HaberBaslik = h.HaberBaslik;
            haber.HaberIcerik = h.HaberIcerik;
            haber.HaberKaynak = h.HaberKaynak;
            haber.Anasayfa = h.Anasayfa;
            haber.OkunmaSayisi = 0;
            haber.EklemeTarihi = DateTime.Now;
            haber.AktifMi = true;

            haberlerManager.TAdd(haber);
            return LocalRedirect("/Admin/Haberler/Index");
        }

        [HttpGet]
        public IActionResult HaberGuncelle(int id)
        {
            var values = haberlerManager.TGetByID(id);
            ViewBag.Resim = values.HaberFoto;
            ViewBag.Adi = values.HaberBaslik;
            return View(values);
        }

        [HttpPost]
        public IActionResult HaberGuncelle(HaberModel h, IFormFile picture)
        {
            var haber = haberlerManager.TGetByID(h.HaberID);
            if (picture != null)
            {
                var extension = Path.GetExtension(picture.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Haberler", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                picture.CopyTo(stream);
                haber.HaberFoto = newimagename;
            }

            haber.HaberBaslik = h.HaberBaslik;
            haber.HaberIcerik = h.HaberIcerik;
            haber.HaberKaynak = h.HaberKaynak;
            haber.Anasayfa = h.Anasayfa;
            haber.AktifMi = h.AktifMi;

            haberlerManager.TUpdate(haber);
            return LocalRedirect("/Admin/Haberler/Index");
        }

        public IActionResult HaberSil(int id)
        {
            var values = haberlerManager.TGetByID(id);
            haberlerManager.TDelete(values);

            var haberFoto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Haberler", values.HaberFoto);

            return LocalRedirect("/Admin/Haberler/Index");
        }

    }
}
