using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AdvenNewWebsite.ViewComponents.Home
{
	public class _SliderPartial : ViewComponent
	{
		SliderlarManager sliderlarManager = new SliderlarManager(new EFSliderlarDAL());
		public IViewComponentResult Invoke()
		{
			var values = sliderlarManager.TGetList();
			return View(values);
		}
	}
}
