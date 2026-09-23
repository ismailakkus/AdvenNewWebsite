using AdvenNewWebsite.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjelerController : Controller
    {
        ProjelerManager projelerManager=new ProjelerManager(new EFProjelerDAL());
        public IActionResult Index()
        {
            var values = projelerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ProjeEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProjeEkle(ProjeModel p)
        {
            Projeler proje = new Projeler();
            if (p.ResimUpload != null)
            {
                var extension = Path.GetExtension(p.ResimUpload.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Projeler", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ResimUpload.CopyTo(stream);
                proje.ProjeResim = newimagename;
            }

            proje.ProjeAdi = p.ProjeAdi;
            proje.ProjeAciklama = p.ProjeAciklama;
            proje.ProjeOzet= p.ProjeOzet;
            proje.ProjeKonum = p.ProjeKonum;
            proje.ProjeKategori = p.ProjeKategori;
            proje.ProjeYatirimci= p.ProjeYatirimci;
            proje.ProjeDurum= p.ProjeDurum;
            proje.EklemeTarihi = DateTime.Now;
            proje.AktifMi = true;

            projelerManager.TAdd(proje);
            return LocalRedirect("/Admin/Projeler/Index");
        }

        [HttpGet]
        public IActionResult ProjeGuncelle(int id)
        {
            var values = projelerManager.TGetByID(id);
            ViewBag.Resim = values.ProjeResim;
            ViewBag.Adi = values.ProjeAdi;
            return View(values);
        }

        [HttpPost]
        public IActionResult ProjeGuncelle(ProjeModel p, IFormFile picture)
        {
            var proje = projelerManager.TGetByID(p.ProjeID);
            if (picture != null)
            {
                var extension = Path.GetExtension(picture.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Projeler", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                picture.CopyTo(stream);
                proje.ProjeResim = newimagename;
            }

            proje.ProjeAdi = p.ProjeAdi;
            proje.ProjeAciklama = p.ProjeAciklama;
            proje.ProjeOzet = p.ProjeOzet;
            proje.ProjeKonum = p.ProjeKonum;
            proje.ProjeKategori = p.ProjeKategori;
            proje.ProjeYatirimci = p.ProjeYatirimci;
            proje.ProjeDurum = p.ProjeDurum;
            proje.EklemeTarihi = DateTime.Now;
            proje.AktifMi = true;

            projelerManager.TUpdate(proje);
            return LocalRedirect("/Admin/Projeler/Index");
        }

        public IActionResult ProjeSil(int id)
        {
            var values = projelerManager.TGetByID(id);
            projelerManager.TDelete(values);

            var projeFoto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Projeler", values.ProjeResim);

            return LocalRedirect("/Admin/Projeler/Index");
        }
    }
}
