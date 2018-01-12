using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AngularJs
{
    public class BundleConfig
    {


        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));
            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //    "~/Styles/Style.css"
                
            //    ));
            bundles.Add(new LessBundle("~/Styles/Less/less").Include("~/Styles/*.less"));
        }

    }
}