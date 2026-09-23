using AdvenNewWebsite.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class KullanicilarController : Controller
    {
        KullanicilarManager kullanicilarManager = new KullanicilarManager(new EFKullanicilarDAL());

        public IActionResult Index()
        {
            var values = kullanicilarManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult KullaniciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KullaniciEkle(KullaniciModel k)
        {
            Kullanicilar kullanici = new Kullanicilar();
            if (k.ResimUpload != null)
            {
                var extension = Path.GetExtension(k.ResimUpload.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Kullanicilar", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                k.ResimUpload.CopyTo(stream);
                kullanici.Resim = newimagename;
            }

            kullanici.AdiSoyadi = k.AdiSoyadi;
            kullanici.KullaniciEmail = k.KullaniciEmail;
            kullanici.KullaniciSifre = k.KullaniciSifre;
            kullanici.Telefon = k.Telefon;
            kullanici.Adres = k.Adres;
            kullanici.Notlar = k.Notlar;
            kullanici.EklemeTarihi = DateTime.Now;
            kullanici.AktifMi = true;

            kullanicilarManager.TAdd(kullanici);
            return LocalRedirect("/Admin/Kullanicilar/Index");
        }

        [HttpGet]
        public IActionResult KullaniciGuncelle(int id)
        {
            var values = kullanicilarManager.TGetByID(id);
            ViewBag.Resim = values.Resim;
            ViewBag.Adi = values.AdiSoyadi;
            return View(values);
        }

        [HttpPost]
        //[Route("KullaniciGuncelle/{id}")]
        public IActionResult KullaniciGuncelle(KullaniciModel k, IFormFile picture)
        {
            var kullanici = kullanicilarManager.TGetByID(k.KullaniciID);

            if (picture != null)
            {
                var extension = Path.GetExtension(picture.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Kullanicilar", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                picture.CopyTo(stream);
                kullanici.Resim = newimagename;
            }


            kullanici.AdiSoyadi = k.AdiSoyadi;
            kullanici.KullaniciEmail = k.KullaniciEmail;
            kullanici.KullaniciSifre = k.KullaniciSifre;
            kullanici.Telefon = k.Telefon;
            kullanici.Adres = k.Adres;
            kullanici.Notlar = k.Notlar;
            kullanici.EklemeTarihi = DateTime.Now;
            kullanici.AktifMi = true;
            kullanicilarManager.TUpdate(kullanici);
            return LocalRedirect("/Admin/Kullanicilar/Index");
        }

        //[Route("KullaniciSil/{id}")]
        public IActionResult KullaniciSil(int id)
        {
            var values = kullanicilarManager.TGetByID(id);
            kullanicilarManager.TDelete(values);
            return LocalRedirect("/Admin/Kullanicilar/Index");
        }
    }
}
