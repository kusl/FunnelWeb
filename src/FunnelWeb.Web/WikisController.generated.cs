// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVC {
    public class WikisController {

        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string WikiController = "~/Features/Wikis/WikiController.cs";
            static readonly _Views s_Views = new _Views();
            public _Views Views { get { return s_Views; } }
            public partial class _Views{
                public readonly string Edit = "~/Features/Wikis/Views/Edit.aspx";
                public readonly string EditModel = "~/Features/Wikis/Views/EditModel.cs";
                public readonly string NotFound = "~/Features/Wikis/Views/NotFound.aspx";
                public readonly string NotFoundModel = "~/Features/Wikis/Views/NotFoundModel.cs";
                public readonly string Page = "~/Features/Wikis/Views/Page.aspx";
                public readonly string PageModel = "~/Features/Wikis/Views/PageModel.cs";
                public readonly string Recent = "~/Features/Wikis/Views/Recent.aspx";
                public readonly string RecentModel = "~/Features/Wikis/Views/RecentModel.cs";
                public readonly string ReviseModel = "~/Features/Wikis/Views/ReviseModel.cs";
                public readonly string Revisions = "~/Features/Wikis/Views/Revisions.aspx";
                public readonly string RevisionsModel = "~/Features/Wikis/Views/RevisionsModel.cs";
                public readonly string SiteMap = "~/Features/Wikis/Views/SiteMap.aspx";
                public readonly string SiteMapModel = "~/Features/Wikis/Views/SiteMapModel.cs";
                public readonly string Unpublished = "~/Features/Wikis/Views/Unpublished.aspx";
            }
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591
