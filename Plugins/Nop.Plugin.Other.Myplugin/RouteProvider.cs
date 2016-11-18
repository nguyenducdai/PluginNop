using Nop.Web.Framework.Mvc.Routes;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using Nop.Plugin.Other.Myplugin.Infrastucture;

namespace Nop.Plugin.Other.Myplugin
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Other.Myplugin.Manage",
                "Aso/Manage",
                new { controller = "Traking", action = "Manage" },
                new[] { "Nop.Plugin.Other.Myplugin.Controllers" }
           );
          // ViewEngines.Engines.Insert(0,new CustomView());
        }

        public int Priority
        {
            get
            {
                return 0;
            }
        }


    }
}
