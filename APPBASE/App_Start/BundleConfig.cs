using System.Web;
using System.Web.Optimization;

namespace APPBASE
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Layout
                //Base
                bundles.Add(new StyleBundle("~/Content/cssLayout").Include(
                            "~/Content/AdminLTE/css/bootstrap.css",
                            "~/Content/AdminLTE/css/font-awesome.css",
                            "~/Content/AdminLTE/css/ionicons.css",
                            "~/Content/AdminLTE/css/AdminLTE.css",
                            "~/Content/Site.css"));
                bundles.Add(new ScriptBundle("~/bundles/modernizrAdminLTE").Include(
                                "~/Scripts/AdminLTE/html5shiv.js",
                                "~/Scripts/AdminLTE/respond.src.js"));
                bundles.Add(new ScriptBundle("~/bundles/JSLayout").Include(
                                "~/Scripts/jquery-2.1.1.js",
                                "~/Scripts/AdminLTE/jquery-ui-1.10.3.js",
                                "~/Scripts/bootstrap.js",
                                "~/Scripts/AdminLTE/app.js",
                                "~/Scripts/AdminLTE/demo.js",
                                "~/Scripts/json2.js",
                                "~/Scripts/ud/jsHelper.js"));

                //Input Mask
                bundles.Add(new ScriptBundle("~/bundles/JSInputMask").Include(
                                "~/Scripts/AdminLTE/jquery.inputmask.js",
                                "~/Scripts/AdminLTE/jquery.inputmask.date.extensions.js",
                                "~/Scripts/AdminLTE/jquery.inputmask.extensions.js"));
                
                //Datepicker
                bundles.Add(new StyleBundle("~/Content/cssDatepicker").Include(
                            "~/Content/AdminLTE/css/datepicker3.css",
                            "~/Content/AdminLTE/css/daterangepicker-bs3.css"));
                bundles.Add(new ScriptBundle("~/bundles/JSDatepicker").Include(
                                "~/Scripts/AdminLTE/datepicker/bootstrap-datepicker.js",
                                "~/Scripts/AdminLTE/daterangepicker.js"));

                //Chart Morris
                bundles.Add(new StyleBundle("~/Content/cssChartmorris").Include(
                            "~/Content/AdminLTE/css/morris.css"));
                bundles.Add(new ScriptBundle("~/bundles/JSChartmorris").Include(
                                "~/Scripts/AdminLTE/chartmorris/raphael.js",
                                "~/Scripts/AdminLTE/chartmorris/morris.js"));

                //Chart Float
                bundles.Add(new ScriptBundle("~/bundles/JSChartfloat").Include(
                                "~/Scripts/AdminLTE/charfloat/jquery.flot.js",
                                "~/Scripts/AdminLTE/charfloat/jquery.flot.resize.js",
                                "~/Scripts/AdminLTE/charfloat/jquery.flot.pie.js",
                                "~/Scripts/AdminLTE/charfloat/jquery.flot.categories.js"));
            #endregion
            #region Layout Report
                bundles.Add(new StyleBundle("~/Content/cssLayoutReport").Include(
                            "~/Content/jquery-ui.css",
                            "~/Content/bootstrap.css",
                            "~/Content/sb-admin-2/font-awesome-4.1.0/css/font-awesome.css",
                            "~/Content/sb-admin-2/metisMenu/metisMenu.css",
                            "~/Content/sb-admin-2/datatables/dataTables.bootstrap.css",
                            //"~/Content/sb-admin-2/datatables/dataTables.tableTools.css",
                            "~/Content/sb-admin-2/sb-admin-2.css",
                            "~/Content/siteReport.css"));
                bundles.Add(new ScriptBundle("~/bundles/JSLayoutReport").Include(
                            "~/Scripts/jquery-1.11.0.js",
                            "~/Scripts/jquery-ui.js",
                            "~/Scripts/bootstrap.js",
                            "~/Scripts/sb-admin-2/metisMenu/metisMenu.js",
                            "~/Scripts/sb-admin-2/dataTables/jquery.dataTables.js",
                            "~/Scripts/sb-admin-2/dataTables/dataTables.tableTools.js",
                            "~/Scripts/sb-admin-2/dataTables/dataTables.bootstrap.js",
                            "~/Scripts/json2.js",
                            "~/Scripts/InputMask.js",
                            "~/Scripts/jquery.format.1.05.js",
                            "~/Scripts/ud/jsHelper.js",
                            "~/Scripts/sb-admin-2/sb-admin-2.js"));
            #endregion
            #region Layout Login
                bundles.Add(new StyleBundle("~/Content/").Include(
                            "~/Content/jquery-ui.css",
                            "~/Content/bootstrap.css",
                            "~/Content/sb-admin-2/metisMenu/metisMenu.css",
                            "~/Content/sb-admin-2/sb-admin-2.css",
                            "~/Content/sb-admin-2/font-awesome-4.1.0/css/font-awesome.css",
                            "~/Content/site.css"));
                bundles.Add(new ScriptBundle("~/bundles/").Include(
                            "~/Scripts/jquery-1.11.0.js",
                            "~/Scripts/jquery-ui.js",
                            "~/Scripts/bootstrap.js",
                            "~/Scripts/json2.js",
                            "~/Scripts/InputMask.js",
                            "~/Scripts/jquery.format.1.05.js",
                            "~/Scripts/ud/jsHelper.js",
                            "~/Scripts/sb-admin-2/metisMenu/metisMenu.js",
                            "~/Scripts/sb-admin-2/sb-admin-2.js"));


                bundles.Add(new StyleBundle("~/Content/cssLayoutLogin").Include(
                            "~/Content/AdminLTE/css/bootstrap.css",
                            "~/Content/AdminLTE/css/font-awesome.css",
                            "~/Content/AdminLTE/css/AdminLTE.css",
                            "~/Content/SiteLogin.css"));
                bundles.Add(new ScriptBundle("~/bundles/JSLayoutLogin").Include(
                                "~/Scripts/jquery-2.1.1.js",
                                "~/Scripts/bootstrap.js"));

            #endregion
            #region Built-In
                bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                            "~/Scripts/AdminLTE/jquery.unobtrusive*",
                            "~/Scripts/jquery.validate*"));

                // Use the development version of Modernizr to develop with and learn from. Then, when you're
                // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
                bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));
            #endregion
        } //End public static void RegisterBundles(BundleCollection bundles)
    } //End public class BundleConfig
} //End namespace APPBASE