using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
    public class _MenuPartial : ViewComponent
    {
        HizmetlerManager hizmetlerManager = new HizmetlerManager(new EFHizmetlerDAL());
        public IViewComponentResult Invoke()
        {
            var values = hizmetlerManager.TGetList();
            return View(values);
        }
    }
}
