using System.Web.Optimization;

namespace VueSample
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundle)
        {
            bundle.Add(new ScriptBundle("~/Scripts").Include(
                "~/Scripts/jquery-3.2.1.min.js",
                "~/Scripts/materialize.min.js",
                "~/Scripts/vue.min.js",
                "~/Scripts/vue-resource.min.js",
                "~/Scripts/index.js"
            ));

            bundle.Add(new StyleBundle("~/Styles/css").Include(
                "~/Content/css/materialize.min.css"
            ));
        }
    }
}