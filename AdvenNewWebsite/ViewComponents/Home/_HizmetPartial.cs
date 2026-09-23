using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
	public class _HizmetPartial : ViewComponent
	{
		HizmetlerManager hizmetlerManager = new HizmetlerManager(new EFHizmetlerDAL());
		public IViewComponentResult Invoke()
		{
			var values = hizmetlerManager.TGetList().Where(x=>x.Anasayfa==true).ToList();
			return View(values);
		}
	}
}
