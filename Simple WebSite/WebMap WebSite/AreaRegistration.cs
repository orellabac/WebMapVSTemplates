
using System.Web.Mvc;
using UpgradeHelpers.WebMap.Server;

namespace $safeprojectname$.Areas
{
    public class Project1AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "$safeprojectname$";
            }
        }


        public override void RegisterArea(AreaRegistrationContext context)
        {
            //var route = context.MapRoute("WebSite_Default", "Home/{controller}/{action}/{id}", new {id = UrlParameter.Optional },new [] { "$safeprojectname$.Controllers"} );
            //route.RouteHandler = new DefaultEventHandlerRouteHandler<HomeController>();
        }
    }
}


