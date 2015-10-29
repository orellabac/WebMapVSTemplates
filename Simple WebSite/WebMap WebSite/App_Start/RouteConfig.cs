using System.Web.Mvc;
using System.Web.Routing;

namespace $safeprojectname$
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //This ignore is added to support having the index.html as Default Document instead of Home/Index
            routes.IgnoreRoute("");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, namespaces: new string[] { "$safeprojectname$.Controllers" }
            );
        }
    }
}