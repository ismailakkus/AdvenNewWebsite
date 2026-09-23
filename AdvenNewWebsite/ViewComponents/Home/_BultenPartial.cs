using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
    public class _BultenPartial : ViewComponent
    {
        BultenlerManager bultenlerManager = new BultenlerManager(new EFBultenlerDAL());
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
