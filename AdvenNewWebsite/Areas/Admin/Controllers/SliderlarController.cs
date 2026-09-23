using AdvenNewWebsite.Areas.Admin.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderlarController : Controller
    {
        SliderlarManager sliderlarManager=new SliderlarManager(new EFSliderlarDAL());
        public IActionResult Index()
        {
            var values = sliderlarManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SliderEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SliderEkle(SliderModel s)
        {
            Sliderlar slider = new Sliderlar();
            if (s.ResimUpload != null)
            {
                var extension = Path.GetExtension(s.ResimUpload.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Sliderlar", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                s.ResimUpload.CopyTo(stream);
                slider.SliderFoto = newimagename;
            }

            slider.SliderBaslik = s.SliderBaslik;
            slider.SliderAciklama = s.SliderAciklama;
            slider.SliderLink = s.SliderLink;
            slider.EklemeTarihi = DateTime.Now;
            slider.AktifMi = true;

            sliderlarManager.TAdd(slider);
            return LocalRedirect("/Admin/Sliderlar/Index");
        }

        [HttpGet]
        public IActionResult SliderGuncelle(int id)
        {
            var values = sliderlarManager.TGetByID(id);
            ViewBag.Resim = values.SliderFoto;
            ViewBag.Adi = values.SliderBaslik;
            return View(values);
        }

        [HttpPost]
        public IActionResult SliderGuncelle(SliderModel s, IFormFile picture)
        {
            var slider = sliderlarManager.TGetByID(s.SliderID);
            if (picture != null)
            {
                var extension = Path.GetExtension(picture.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Sliderlar", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                picture.CopyTo(stream);
                slider.SliderFoto = newimagename;
            }

            slider.SliderBaslik = s.SliderBaslik;
            slider.SliderAciklama = s.SliderAciklama;
            slider.SliderLink = s.SliderLink;
            slider.EklemeTarihi = DateTime.Now;
            slider.AktifMi = s.AktifMi;

            sliderlarManager.TUpdate(slider);
            return LocalRedirect("/Admin/Sliderlar/Index");
        }

        public IActionResult SliderSil(int id)
        {
            var values = sliderlarManager.TGetByID(id);
            sliderlarManager.TDelete(values);

            var sliderFoto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Sliderlar", values.SliderFoto);

            return LocalRedirect("/Admin/Sliderlar/Index");
        }

    }
}
