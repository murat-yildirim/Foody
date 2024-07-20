using Microsoft.AspNetCore.Mvc;

namespace Foddy.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _ScriptsLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
