using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
	public class _ReferansPartial:ViewComponent
	{
		ReferanslarManager referanslarManager=new ReferanslarManager(new EFReferanslarDAL());
		public IViewComponentResult Invoke()
		{
			var values = referanslarManager.TGetList();
			return View(values);
		}
	}
}
