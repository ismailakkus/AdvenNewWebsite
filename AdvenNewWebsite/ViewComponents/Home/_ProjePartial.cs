using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
    public class _ProjePartial:ViewComponent
    {
        ProjelerManager projelerManager = new ProjelerManager(new EFProjelerDAL());
        public IViewComponentResult Invoke()
        {
            int total = projelerManager.TGetList().Count();
            Random r = new Random();
            int offset = r.Next(0, total);

            var values = projelerManager.TGetList().Skip(offset).Take(1).ToList();

            //var values = projelerManager.TGetListWithTake1Random();
            return View(values);
        }
    }
}
