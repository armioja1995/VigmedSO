using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace VigmedSO
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Js").Include(
                      "~/Content/plugins/jQuery/jquery-2.2.3.min.js",
                      "~/Content/bootstrap/js/bootstrap.min.js",
                      "~/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                      "~/Content/plugins/fastclick/fastclick.js",
                      "~/Content/dist/js/app.min.js",
                      "~/Content/dist/js/demo.js",
                      "~/Content/plugins/datatables/jquery.dataTables.js",
                      "~/Content/plugins/datatables-bs4/js/dataTables.bootstrap4.js"
                      //"~/Content/plugins/datatables/jquery.dataTables.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/bootstrap/css/bootstrap.min.css",
                      "~/Content/dist/css/AdminLTE.min.css",
                      "~/Content/dist/css/skins/_all-skins.min.css",
                      "~/Content/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/plugins/datatables-bs4/css/dataTables.bootstrap4.css"
                      //"~/Content/plugins/datatables/jquery.dataTables.min.css"
                      ));

            BundleTable.EnableOptimizations = true;
        }
    }
}
