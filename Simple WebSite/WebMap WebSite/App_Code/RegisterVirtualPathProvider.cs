using System.Reflection;
using System.Linq;
namespace $safeprojectname$
{
	public class RegisterVirtualPathProvider
	{
		public static void AppInitialize()
		{
			//By default, we scan all non system assemblies for embedded resources
			var assemblies = System.Web.Compilation.BuildManager.GetReferencedAssemblies()
				.Cast<Assembly>()
				.Where(
					a =>
						a.GetName().Name.Equals("UpgradeHelpers.WebMap.Controls") ||
						a.GetName().Name.Equals("UpgradeHelpers.WebMap.Client") ||
						(!a.GetName().Name.StartsWith("System") && !a.GetName().Name.StartsWith("UpgradeHelpers") &&
						 !a.GetName().Name.StartsWith("Microsoft")));
			System.Web.Hosting.HostingEnvironment.RegisterVirtualPathProvider(new ResourceVirtualPathProvider.Vpp(assemblies.ToArray())
			{
				//you can do a specific assembly registration too. If you provide the assemly source path, it can read
				//from the source file so you can change the content while the app is running without needing to rebuild
				//{typeof(SomeAssembly.SomeClass).Assembly, @"..\SomeAssembly"} 
			});
		}
	}
}