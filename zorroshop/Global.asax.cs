using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using zorroshop.Models;
using System.Data.Entity;

namespace zorroshop
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {

            Database.SetInitializer(new DBInitializer());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
