﻿using Microsoft.AspNetCore.Mvc;

namespace Foddy.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _HeadLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
