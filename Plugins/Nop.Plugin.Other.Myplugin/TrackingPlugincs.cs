using Nop.Core.Plugins;
using Nop.Plugin.Other.Myplugin.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Menu;
using System.Linq;
using System.Web.Routing;

namespace Nop.Plugin.Other.Myplugin
{
    public class TrackingPlugincs : BasePlugin, IAdminMenuPlugin
    {
        private readonly TrackingRecordObjectContext _context;
        private ILocalizationService _localizationService;

        public TrackingPlugincs(TrackingRecordObjectContext context, ILocalizationService localizationService)
        {
            _context = context;
            _localizationService = localizationService;
        }

        //public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        //{
        //    actionName = "Manage";
        //    controllerName = "Traking";
        //    routeValues = new RouteValueDictionary()
        //    {
        //        {"Namespaces", "Nop.Plugin.Other.Myplugin.Controllers"},
        //        {"area", null}
        //    };
        //    }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }
        
        // Add Item menu
        public void ManageSiteMap(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                // SystemName = "Myplugin",
                SystemName = "Mở Rộng",
                Title = "Aso plugin",
                ControllerName = "Traking",
                ActionName = "Manage",
                Visible = true,
                RouteValues = new RouteValueDictionary() {
                    { "area", null } },
                IconClass = "fa-dot-circle-o"
            };
            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Content management");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }
    }
}