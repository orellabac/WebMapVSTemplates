using System.Web.Mvc;
using UpgradeHelpers.WebMap.Server;

namespace $safeprojectname$
{
    public class FilterConfig
    {
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
			filters.Add(new ViewManagerRequestStartAndEndActionFilter());
			filters.Add(new SessionExpireFilterAttribute());
		}
    }
}