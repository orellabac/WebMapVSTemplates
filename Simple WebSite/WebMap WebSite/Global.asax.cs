using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using UpgradeHelpers.WebMap.Server;

namespace $safeprojectname$
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public partial class MvcApplication : System.Web.HttpApplication
    {


        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //The current assembly must be sent to register any ViewModels defined in it
            Bootstrapper.Initialize(this.GetType().Assembly);
        }

        protected void Session_Start()
        {
            
        }
    }
}