#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f0bfe21b1950f859bf1b1edfdad7eec583e6be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Pagination), @"mvc.1.0.view", @"/Views/Shared/_Pagination.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f0bfe21b1950f859bf1b1edfdad7eec583e6be", @"/Views/Shared/_Pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.Pagination>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n<ul class=\"pagination\">\r\n");
#nullable restore
#line 4 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
           
        if (Model.PageIndex != 1)
        {
            if (Model.PageIndex > 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 252, "\"", 303, 4);
            WriteAttributeValue("", 259, "/", 259, 1, true);
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 260, Model.Route, 260, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 274, "page=1&items=", 274, 13, true);
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 287, Model.PageItems, 287, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">«</a>\r\n                </li>\r\n");
#nullable restore
#line 12 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 422, "\"", 492, 6);
            WriteAttributeValue("", 429, "/", 429, 1, true);
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 430, Model.Route, 430, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 444, "page=", 444, 5, true);
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 449, Model.PageIndex-1, 449, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 469, "&items=", 469, 7, true);
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 476, Model.PageItems, 476, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
                                                                                                        Write(Model.PageIndex-1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item active\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 623, "\"", 691, 6);
            WriteAttributeValue("", 630, "/", 630, 1, true);
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 631, Model.Route, 631, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 645, "page=", 645, 5, true);
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 650, Model.PageIndex, 650, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 668, "&items=", 668, 7, true);
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 675, Model.PageItems, 675, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
                                                                                                  Write(Model.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n");
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
        if (Model.TotalPages > Model.PageIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 864, "\"", 934, 6);
            WriteAttributeValue("", 871, "/", 871, 1, true);
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 872, Model.Route, 872, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 886, "page=", 886, 5, true);
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 891, Model.PageIndex+1, 891, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 911, "&items=", 911, 7, true);
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 918, Model.PageItems, 918, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
                                                                                                        Write(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"

            if (Model.TotalPages > Model.PageIndex + 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1137, "\"", 1204, 6);
            WriteAttributeValue("", 1144, "/", 1144, 1, true);
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 1145, Model.Route, 1145, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1159, "page=", 1159, 5, true);
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 1164, Model.TotalPages, 1164, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1181, "&items=", 1181, 7, true);
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
WriteAttributeValue("", 1188, Model.PageItems, 1188, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n                </li>\r\n");
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\Shared\_Pagination.cshtml"
            }


        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.Pagination> Html { get; private set; }
    }
}
#pragma warning restore 1591