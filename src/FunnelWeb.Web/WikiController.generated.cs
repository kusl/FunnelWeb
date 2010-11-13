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
namespace FunnelWeb.Web.Features.Wiki {
    public partial class WikiController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public WikiController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected WikiController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Recent() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Recent);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Search() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Search);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult NotFound() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.NotFound);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Page() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Page);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Edit() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Save() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Save);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Comment() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Comment);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Revisions() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Revisions);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public WikiController Actions { get { return FunnelWebMvc.Wiki; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Wiki";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Recent = "Recent";
            public readonly string Search = "Search";
            public readonly string NotFound = "NotFound";
            public readonly string Page = "Page";
            public readonly string New = "New";
            public readonly string Edit = "Edit";
            public readonly string Unpublished = "Unpublished";
            public readonly string Save = "Save";
            public readonly string Comment = "Comment";
            public readonly string Revisions = "Revisions";
            public readonly string SiteMap = "SiteMap";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string WikiController = "~/Features/Wiki/WikiController.cs";
            static readonly _Views s_Views = new _Views();
            public _Views Views { get { return s_Views; } }
            public partial class _Views{
                public readonly string Edit = "~/Features/Wiki/Views/Edit.aspx";
                public readonly string EditModel = "~/Features/Wiki/Views/EditModel.cs";
                public readonly string NotFound = "~/Features/Wiki/Views/NotFound.aspx";
                public readonly string NotFoundModel = "~/Features/Wiki/Views/NotFoundModel.cs";
                public readonly string Page = "~/Features/Wiki/Views/Page.aspx";
                public readonly string PageModel = "~/Features/Wiki/Views/PageModel.cs";
                public readonly string Recent = "~/Features/Wiki/Views/Recent.aspx";
                public readonly string RecentModel = "~/Features/Wiki/Views/RecentModel.cs";
                public readonly string ReviseModel = "~/Features/Wiki/Views/ReviseModel.cs";
                public readonly string Revisions = "~/Features/Wiki/Views/Revisions.aspx";
                public readonly string RevisionsModel = "~/Features/Wiki/Views/RevisionsModel.cs";
                public readonly string SiteMap = "~/Features/Wiki/Views/SiteMap.aspx";
                public readonly string SiteMapModel = "~/Features/Wiki/Views/SiteMapModel.cs";
                public readonly string Unpublished = "~/Features/Wiki/Views/Unpublished.aspx";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_WikiController: FunnelWeb.Web.Features.Wiki.WikiController {
        public T4MVC_WikiController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Recent(int pageNumber) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Recent);
            callInfo.RouteValueDictionary.Add("pageNumber", pageNumber);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Search(string searchText) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Search);
            callInfo.RouteValueDictionary.Add("q", searchText);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult NotFound(string searchText) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.NotFound);
            callInfo.RouteValueDictionary.Add("searchText", searchText);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Page(FunnelWeb.Web.Model.Strings.PageName page, int revision) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Page);
            callInfo.RouteValueDictionary.Add("page", page);
            callInfo.RouteValueDictionary.Add("revision", revision);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult New() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.New);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(FunnelWeb.Web.Model.Strings.PageName page) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("page", page);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Unpublished() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Unpublished);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Save(FunnelWeb.Web.Model.Strings.PageName page, string title, string metaTitle, string summary, string body, string comment, string metaDescription, string metaKeywords, bool enableDiscussion, int[] feeds) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Save);
            callInfo.RouteValueDictionary.Add("page", page);
            callInfo.RouteValueDictionary.Add("title", title);
            callInfo.RouteValueDictionary.Add("metaTitle", metaTitle);
            callInfo.RouteValueDictionary.Add("summary", summary);
            callInfo.RouteValueDictionary.Add("body", body);
            callInfo.RouteValueDictionary.Add("comment", comment);
            callInfo.RouteValueDictionary.Add("metaDescription", metaDescription);
            callInfo.RouteValueDictionary.Add("metaKeywords", metaKeywords);
            callInfo.RouteValueDictionary.Add("enableDiscussion", enableDiscussion);
            callInfo.RouteValueDictionary.Add("feeds", feeds);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Comment(FunnelWeb.Web.Model.Strings.PageName page, string name, string url, string email, string comments) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Comment);
            callInfo.RouteValueDictionary.Add("page", page);
            callInfo.RouteValueDictionary.Add("name", name);
            callInfo.RouteValueDictionary.Add("url", url);
            callInfo.RouteValueDictionary.Add("email", email);
            callInfo.RouteValueDictionary.Add("comments", comments);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Revisions(FunnelWeb.Web.Model.Strings.PageName page) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Revisions);
            callInfo.RouteValueDictionary.Add("page", page);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult SiteMap() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.SiteMap);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
