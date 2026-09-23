using AdvenNewWebsite.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SureclerController : Controller
    {
        SureclerManager sureclerManager = new SureclerManager(new EFSureclerDAL());
        public IActionResult Index()
        {
            var values = sureclerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SurecEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SurecEkle(SurecModel s)
        {
            Surecler surec = new Surecler();

            surec.SurecAdi = s.SurecAdi;
            surec.SurecIkon = s.SurecIkon;
            surec.SurecAciklama = s.SurecAciklama;
            surec.AktifMi = true;

            sureclerManager.TAdd(surec);
            return LocalRedirect("/Admin/Surecler/Index");
        }

        [HttpGet]
        public IActionResult SurecGuncelle(int id)
        {
            var values = sureclerManager.TGetByID(id);
            ViewBag.Adi = values.SurecAdi;
            ViewBag.Ikon = values.SurecIkon;
            return View(values);
        }

        [HttpPost]
        public IActionResult SurecGuncelle(SurecModel s)
        {
            var surec = sureclerManager.TGetByID(s.SurecID);

            surec.SurecAdi = s.SurecAdi;
            surec.SurecIkon = s.SurecIkon;
            surec.SurecAciklama = s.SurecAciklama;
            surec.AktifMi = true;

            sureclerManager.TUpdate(surec);
            return LocalRedirect("/Admin/Surecler/Index");
        }

        public IActionResult SurecSil(int id)
        {
            var values = sureclerManager.TGetByID(id);
            sureclerManager.TDelete(values);

            return LocalRedirect("/Admin/Surecler/Index");
        }
    }
}
