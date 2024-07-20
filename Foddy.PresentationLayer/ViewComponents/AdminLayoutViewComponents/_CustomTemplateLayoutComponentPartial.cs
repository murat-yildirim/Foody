using Microsoft.AspNetCore.Mvc;

namespace Foddy.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _CustomTemplateLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
