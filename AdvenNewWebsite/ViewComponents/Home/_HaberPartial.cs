using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
    public class _HaberPartial : ViewComponent
    {
        HaberlerManager haberlerManager = new HaberlerManager(new EFHaberlerDAL());
        public IViewComponentResult Invoke()
        {
            var values = haberlerManager.TGetList();
            return View(values);
        }
    }
}
