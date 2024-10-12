using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Views.Shared.Components._LayoutHeaderPartialComponent;

public class _LayoutNavbarComponentPartial:ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
