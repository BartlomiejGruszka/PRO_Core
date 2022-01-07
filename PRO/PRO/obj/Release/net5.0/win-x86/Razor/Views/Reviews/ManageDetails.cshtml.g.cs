#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d97962fc9542a2c9fe498ad56a807d9257279d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_ManageDetails), @"mvc.1.0.view", @"/Views/Reviews/ManageDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PRO_Core\PRO\PRO\Views\_ViewImports.cshtml"
using PRO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Views\_ViewImports.cshtml"
using PRO.UI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d97962fc9542a2c9fe498ad56a807d9257279d", @"/Views/Reviews/ManageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_ManageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
  
    ViewBag.Title = "ManageDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2 class=\"list-title box-shadow\">Szczegóły recenzji</h2>\r\n<div class=\"window-background box-shadow p-3\">\r\n    <div>\r\n\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Game));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Game.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 23 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Moderator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 41 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
                 if (Model.Moderator == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Brak</p> ");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
                             }
                else
                { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
             Write(Html.DisplayFor(model => model.Moderator.User.UserName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.EditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");
#nullable restore
#line 52 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
                 if (Model.EditDate == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Brak</p> ");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
                             }
                else
                { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
             Write(Html.DisplayFor(model => model.EditDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 58 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 62 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.Raw(@Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.GraphicsScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.GraphicsScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.StoryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.StoryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 81 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.MusicScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 85 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.MusicScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.GameplayScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 93 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.GameplayScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n    <hr />\r\n    <p>\r\n        <div class=\"btn btn-primary\"><a class=\"actionLinkManage\"");
            BeginWriteAttribute("href", " href=\"", 2623, "\"", 2653, 2);
            WriteAttributeValue("", 2630, "/reviews/edit/", 2630, 14, true);
#nullable restore
#line 100 "D:\PRO_Core\PRO\PRO\Views\Reviews\ManageDetails.cshtml"
WriteAttributeValue("", 2644, Model.Id, 2644, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a></div>\r\n        <a href=\"#\" class=\"btn btn-secondary\" onclick=\"javascript:window.history.back(-1);return false;\">Powrót</a>\r\n    </p>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
