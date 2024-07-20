using Microsoft.AspNetCore.Mvc;

namespace Foddy.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _MainPanelLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
