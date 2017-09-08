using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace Charts
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/css").Include(
                            "~/Content/Site.css",
                            "~/Content/Bootstrap.css",
                            "~/Content/Bootstrap.min.css"));
        }
    }
}