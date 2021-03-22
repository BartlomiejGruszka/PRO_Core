#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef2b457ca2c2a5bed996e3a6d1ffc14a011d18c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Manage), @"mvc.1.0.view", @"/Views/Series/Manage.cshtml")]
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
using PRO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef2b457ca2c2a5bed996e3a6d1ffc14a011d18c", @"/Views/Series/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4578dd96b4e1783e15166ecff815f4ae736b10d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Series_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PRO.Entities.Series>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Zarządzaj seriami</h2>

<p>
    <div class=""btn btn-primary""><a class=""actionLinkManage"" href=""/series/add"">Dodaj nową</a></div>
    <div class=""btn btn-secondary""><a class=""actionLinkManage"" href=""/panel"">Powrót</a></div>
</p>
<table class=""table"">
    <tr>
        <th>
            ");
#nullable restore
#line 17 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
       var start = ViewBag.Pagination.pageIteratorStart;
        var end = ViewBag.Pagination.pageIteratorEnd;
        for (var i = start; i <= end; i++)
        {
            var item = Model.ToArray()[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
               Write(Html.ActionLink("Edytuj", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
               Write(Html.ActionLink("Szczegóły", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
                     if (@User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
               Write(Html.ActionLink("Usuń", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
                                                                            
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td></td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<div>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
          
            var first = ViewBag.Pagination.firstPage;
            var current = ViewBag.Pagination.currentPage;
            var previous = ViewBag.Pagination.previousPage;
            var items = ViewBag.Pagination.itemsPerPage;
            var next = ViewBag.Pagination.nextPage;
            var last = ViewBag.Pagination.lastPage;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
          
            if (@current >= 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1900, "\"", 1946, 4);
            WriteAttributeValue("", 1907, "/series/manage?page=", 1907, 20, true);
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 1927, first, 1927, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1933, "&items=", 1933, 7, true);
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 1940, items, 1940, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">«</a>\r\n                </li>\r\n");
#nullable restore
#line 67 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
            }
            if (@current >= 2 && @previous != @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2145, "\"", 2194, 4);
            WriteAttributeValue("", 2152, "/series/manage?page=", 2152, 20, true);
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2172, previous, 2172, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2181, "&items=", 2181, 7, true);
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2188, items, 2188, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
                                                                                      Write(previous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2330, "\"", 2378, 4);
            WriteAttributeValue("", 2337, "/series/manage?page=", 2337, 20, true);
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2357, current, 2357, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2365, "&items=", 2365, 7, true);
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2372, items, 2372, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
                                                                                 Write(current);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 78 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"

            if (@last > @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2545, "\"", 2590, 4);
            WriteAttributeValue("", 2552, "/series/manage?page=", 2552, 20, true);
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2572, next, 2572, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2577, "&items=", 2577, 7, true);
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2584, items, 2584, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
                                                                                  Write(next);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 84 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
            }

            if (@last > @current + 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2777, "\"", 2822, 4);
            WriteAttributeValue("", 2784, "/series/manage?page=", 2784, 20, true);
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2804, last, 2804, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2809, "&items=", 2809, 7, true);
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
WriteAttributeValue("", 2816, items, 2816, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n                </li>\r\n");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Series\Manage.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PRO.Entities.Series>> Html { get; private set; }
    }
}
#pragma warning restore 1591
