using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
    public class _IconPartial:ViewComponent
    {
        SureclerManager sureclerManager = new SureclerManager(new EFSureclerDAL());
        public IViewComponentResult Invoke()
        {
            var values = sureclerManager.TGetList().Where(x=>x.AktifMi==true).ToList();
            return View(values);
        }
    }
}
