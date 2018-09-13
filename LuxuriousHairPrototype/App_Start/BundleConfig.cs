﻿using System.Web;
using System.Web.Optimization;

namespace LuxuriousHairPrototype
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
             "~/admin-lte/js/app.js",
             "~/admin-lte/plugins/fastclick/fastclick.js",
           "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", 
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/skins/skin-blue.css",
                      "~/admin-lte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));

            #region Template Design

            bundles.Add(new ScriptBundle("~/template/js").Include(
                       "~/Scripts/jquery-3.2.1.min.js",
                       "~/Content/styles/bootstrap4/popper.js",
                       "~/Content/styles/bootstrap4/bootstrap.min.js",
                       "~/Content/plugins/Isotope/isotope.pkgd.min.js",
                       "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                       "~/Content/plugins/easing/easing.js",
                       "~/Scripts/custom.js"
                       ));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/styles/bootstrap4/bootstrap.min.css",
                      "~/Content/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                      "~/Content/plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                      "~/Content/plugins/OwlCarousel2-2.2.1/animate.css",
                      "~/Content/styles/main_styles.css",
                      "~/Content/styles/responsive.css"
                      ));
            #endregion
        }
    }
}
