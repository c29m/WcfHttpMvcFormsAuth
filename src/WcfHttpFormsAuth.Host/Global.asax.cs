using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.ServiceModel.Http;

namespace WcfHttpFormsAuth.Host {
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class Global : System.Web.HttpApplication {
		public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes) {
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // Parameter defaults
				new { controller = new WcfRoutesConstraint(new string[] {"contact","login"}) }
			);

			var catalog = new AssemblyCatalog(typeof(Global).Assembly);
			var container = new CompositionContainer(catalog);
			var configuration = new ContactManagerConfiguration(container);
			RouteTable.Routes.AddServiceRoute<ContactResource>("contact", configuration);
			RouteTable.Routes.AddServiceRoute<LoginResource>("login", configuration);

		}

		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);
		}
	}

	public class WcfRoutesConstraint : IRouteConstraint {
		public WcfRoutesConstraint(params string[] values) {
			this._values = values;
		}

		private string[] _values;

		public bool Match(HttpContextBase httpContext,
		Route route,
		string parameterName,
		RouteValueDictionary values,
		RouteDirection routeDirection) {
			// Get the value called "parameterName" from the
			// RouteValueDictionary called "value"
			string value = values[parameterName].ToString();

			// Return true is the list of allowed values contains
			// this value.
			bool match = !_values.Contains(value);
			return match;
		}
	}
}