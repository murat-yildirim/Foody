using Microsoft.AspNetCore.Mvc;

namespace Foddy.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _SidebarLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
