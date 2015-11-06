using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpgradeHelpers.WebMap.Server;

namespace $rootnamespace$.Controllers
{
    public class $basename$Controller : Controller
    {
        $basename$ logic { get; set; }

        public ActionResult button1_click($basename$ViewModel viewFromClient, object eventSender)
        {
            logic.ViewModel = viewFromClient;
            logic.button1_click();
            return new AppChanges();
        }

    }
}