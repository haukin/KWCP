using System.Web;
using System.Web.Optimization;

namespace kwcp {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libs/jquery/jquery-{version}.js"));
                        
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/libs/materialize/materialize.js",
                      "~/Scripts/libs/respond/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css/core").Include(
                      "~/Content/css/libs/materialize/materialize.css"));

            //BundleTable.EnableOptimizations = true;
        }
    }
}
