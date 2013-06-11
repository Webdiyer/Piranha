﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Template
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Template/PostEdit.cshtml")]
    public partial class PostEdit : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.TemplateModels.PostEditModel>
    {
        public PostEdit()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
  
    ViewBag.Selected = "Settings" ;
    ViewBag.SelectedTab = "PostType" ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 195), Tuple.Create("\"", 255)
, Tuple.Create(Tuple.Create("", 201), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.template.js")
, 201), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(document).ready(function () {\r\n            $(\'#Template_Name\').focus" +
"();\r\n        });\r\n    </script>\r\n");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 15 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 19 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 637), Tuple.Create("\"", 701)
            
            #line 20 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
, Tuple.Create(Tuple.Create("", 644), Tuple.Create<System.Object, System.Int32>(Url.Action("deletepost", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 644), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                                                              Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 786), Tuple.Create("\"", 816)
            
            #line 21 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
, Tuple.Create(Tuple.Create("", 793), Tuple.Create<System.Object, System.Int32>(Url.Action("postlist")
            
            #line default
            #line hidden
, 793), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 21 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                          Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 897), Tuple.Create("\"", 955)
            
            #line 22 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
, Tuple.Create(Tuple.Create("", 904), Tuple.Create<System.Object, System.Int32>(Url.Action("post", new { id = Model.Template.Id })
            
            #line default
            #line hidden
, 904), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 22 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                                                         Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

            
            #line 28 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
   Html.BeginForm("post", "template") ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 30 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 31 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.PermalinkId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 32 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 33 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 34 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.Updated));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 35 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 36 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.UpdatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 37 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.IsNew));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 39 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 40 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.Created));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 41 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Permalink.CreatedBy));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 42 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
     if (!Piranha.Application.Current.IsMvc) {
    
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.View));

            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                         
    
            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
Write(Html.HiddenFor(m => m.Template.ShowView));

            
            #line default
            #line hidden
            
            #line 44 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                             
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"grid_9\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box expandable\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 49 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 53 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 55 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 56 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Template.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"protected\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 59 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Permalink));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 60 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                	
            
            #line default
            #line hidden
            
            #line 60 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                  if (!Model.Permalink.IsNew) {

            
            #line default
            #line hidden
WriteLiteral("                    <p>");

            
            #line 61 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                  Write(Piranha.WebPages.WebPiranha.GetSiteUrl());

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 61 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                             Write(Model.HandlerPrefix);

            
            #line default
            #line hidden
            
            #line 61 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                                                  Write(Url.GetPermalink(Model.Permalink.Name).ToLower());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 62 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                    } else {

            
            #line default
            #line hidden
WriteLiteral("                    <p><i>");

            
            #line 63 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                     Write(Piranha.Resources.Page.PermalinkDescription);

            
            #line default
            #line hidden
WriteLiteral("</i></p>\r\n");

            
            #line 64 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 66 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Permalink.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <a");

WriteLiteral(" class=\"locked\"");

WriteLiteral("></a>\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 70 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 72 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Description, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n            <ul");

WriteLiteral(" class=\"form optional\"");

WriteLiteral(">               \r\n                <li>");

            
            #line 77 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Preview));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                   Write(Html.TextAreaFor(m => m.Template.Preview, new { @rows = 8} ));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>                \r\n            </ul>\r\n        </div>\r" +
"\n    </div>\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 85 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                          Write(Piranha.Resources.Global.Advanced);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>");

            
            #line 88 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.Controller,
                        Piranha.Application.Current.IsMvc ? Piranha.Resources.Post.Route : Piranha.Resources.Post.Template));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 91 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.Controller, 
                            new { @placeholder = "Post" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 94 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowController));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 95 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                    Write(Piranha.Application.Current.IsMvc ? Piranha.Resources.Template.PostRouteOverride : Piranha.Resources.Template.PostTemplateOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n");

            
            #line 97 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 97 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                 if (Piranha.Application.Current.IsMvc) {

            
            #line default
            #line hidden
WriteLiteral("                <li>");

            
            #line 98 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.View));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 100 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.View, new { @placeholder = "Index" }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 102 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowView));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 102 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                              Write(Piranha.Resources.Template.PostViewOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n");

            
            #line 104 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <li>");

            
            #line 105 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.ArchiveController));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 107 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                   Write(Html.TextBoxFor(m => m.Template.ArchiveController, 
                            new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <label>&nbsp;</label>\r\n                    <p>");

            
            #line 110 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.ShowArchiveController));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 110 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                                           Write(Piranha.Resources.Template.PostRedirectOverride);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 113 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
               Write(Html.LabelFor(m => m.Template.AllowRss));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <p>");

            
            #line 114 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                  Write(Html.CheckBoxFor(m => m.Template.AllowRss));

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 114 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                                               Write(Piranha.Resources.Template.AllowRssDescription);

            
            #line default
            #line hidden
WriteLiteral(")</p>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</di" +
"v>\r\n<div");

WriteLiteral(" class=\"grid_3\"");

WriteLiteral(">\r\n");

            
            #line 121 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 121 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
     if (!Model.Template.IsNew && !String.IsNullOrEmpty(Model.Template.Preview.ToHtmlString())) {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box pagetemplate\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 123 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                          Write(Piranha.Resources.Page.HtmlPreview);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"edit\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 126 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
           Write(Model.Template.Preview);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 130 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 132 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                          Write(Piranha.Resources.Global.Properties);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"region_data\"");

WriteLiteral("></div>\r\n            <ul");

WriteLiteral(" id=\"properties\"");

WriteLiteral(" class=\"list buttons\"");

WriteLiteral(">\r\n");

            
            #line 136 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 136 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                 foreach (var property in Model.Template.Properties) {

            
            #line default
            #line hidden
WriteLiteral("                <li><span>");

            
            #line 137 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                     Write(property);

            
            #line default
            #line hidden
WriteLiteral("</span><button");

WriteLiteral(" class=\"btn delete right remove-region\"");

WriteLiteral("></button></li>\r\n");

            
            #line 138 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"po_name\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 6576), Tuple.Create("\"", 6637)
            
            #line 141 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
, Tuple.Create(Tuple.Create("", 6590), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Template.PropertyPlaceholder
            
            #line default
            #line hidden
, 6590), false)
);

WriteLiteral(" /></div>\r\n            <button");

WriteLiteral(" id=\"po_add\"");

WriteLiteral(" class=\"btn right\"");

WriteLiteral(">");

            
            #line 142 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
                                             Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n         </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 147 "..\..\Areas\Manager\Views\Template\PostEdit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591