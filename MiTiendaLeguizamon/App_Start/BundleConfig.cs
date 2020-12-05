using System.Web;
using System.Web.Optimization;

namespace MiTiendaLeguizamon
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                        "~/Scripts/template/jquery.min.js",
                        "~/Scripts/template/popper.min.js",
                        "~/Scripts/template/jquery.easing.1.3.js",
                        "~/Scripts/template/jquery.waypoints.min.js",
                        "~/Scripts/template/jquery.flexslider-min.js",
                        "~/Scripts/template/owl.carousel.min.js",
                        "~/Scripts/template/jquery.magnific-popup.min.js",
                        "~/Scripts/template/magnific-popup-options.js",
                        "~/Scripts/template/bootstrap-datepicker.js",
                        "~/Scripts/template/jquery.stellar.min.js",
                        "~/Scripts/template/main.js"
                        ));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                      "~/Content/template/animate.css",
                      "~/Content/template/icomoon.css",
                      "~/Content/template/ionicons.min.css",
                      "~/Content/template/magnific-popup.css",
                      "~/Content/template/flexslider.css",
                      "~/Content/template/owl.carousel.min.css",
                      "~/Content/template/owl.theme.default.min.css",
                      "~/Content/template/bootstrap-datepicker.css",
                      "~/Content/template/style.css"
                      ));
        }
    }
}
