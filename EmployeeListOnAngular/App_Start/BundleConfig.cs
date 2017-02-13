using System.Web.Optimization;

namespace EmployeeListOnAngular.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-route.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/app.js",
                "~/Scripts/app/employeesControllers.js",
                "~/Scripts/app/remoteService.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/site.css"
                ));
        }
    }
}