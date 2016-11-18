using Nop.Web.Framework.Themes;

namespace Nop.Plugin.Other.Myplugin.Infrastucture
{
    public class CustomView : ThemeableRazorViewEngine
    {
        public CustomView()
        {
            ViewLocationFormats = new[] {"~/Plugins/Other.Myplugin/Views/{0}.cshtml"};
            PartialViewLocationFormats = new[] {"~/Plugins/Other.Myplugin/Views/{0}.cshtml"};
        }
    }
}