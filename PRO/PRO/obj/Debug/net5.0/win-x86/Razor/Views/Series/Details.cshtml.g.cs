#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5834e1d986836833065c475a7a673b7c2cdce25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Details), @"mvc.1.0.view", @"/Views/Series/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5834e1d986836833065c475a7a673b7c2cdce25", @"/Views/Series/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Series_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.Series>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Szczegóły serii</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Gry w serii\r\n        </dt>\r\n\r\n        <dd>\r\n");
#nullable restore
#line 25 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
             foreach (var item in Model.Games)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
           Write(Html.DisplayFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 28 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
             if (Model.Games.Count() == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak gier w serii</p>");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<p>\r\n    <div class=\"btn btn-primary\"><a class=\"actionLinkManage\"");
            BeginWriteAttribute("href", " href=\"", 746, "\"", 775, 2);
            WriteAttributeValue("", 753, "/series/edit/", 753, 13, true);
#nullable restore
#line 35 "D:\PRO_Core\PRO\PRO\Views\Series\Details.cshtml"
WriteAttributeValue("", 766, Model.Id, 766, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a></div>\r\n    <a href=\"#\" class=\"btn btn-secondary\" onclick=\"javascript:window.history.back(-1);return false;\">Powrót</a>\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.Series> Html { get; private set; }
    }
}
#pragma warning restore 1591
