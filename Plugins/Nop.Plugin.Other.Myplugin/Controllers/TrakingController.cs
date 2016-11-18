using Nop.Core.Data;
using Nop.Plugin.Other.Myplugin.Domain;
using Nop.Web.Framework.Controllers;
using System.Web.Mvc;

namespace Nop.Plugin.Other.Myplugin.Controller
{
    public class TrakingController : BasePluginController
    {
        private IRepository<TrackingRecord> _iRepository;

        public TrakingController(IRepository<TrackingRecord> iRepository)
        {
            _iRepository = iRepository;
        }

       // [AdminAuthorize]
        public ActionResult Manage()
        {
            //return "hello word";
            return View("~/Plugins/Orther.Myplugin/Views/Manages.cshtml");
        }
    }
}