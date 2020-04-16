﻿using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                                "~/Scripts/bootstrap.js",
                                "~/Scripts/bootbox.js",
                                "~/Scripts/jquery-{version}.js",
                                "~/Scripts/datatables/jquery.dataTables.js",
                                "~/Scripts/datatables/dataTables.bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen-one.css",
                      "~/Content/site.css",
                      "~/Content/datatables/css/datatables.bootsrap.css",
                      "~/Content/bootstrap.min.css"));
        }
    }
}
