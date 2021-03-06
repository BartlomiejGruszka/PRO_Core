#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8347995461336d4f2f659857e54bc5a7a2c54de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Manage), @"mvc.1.0.view", @"/Views/Tags/Manage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8347995461336d4f2f659857e54bc5a7a2c54de", @"/Views/Tags/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4578dd96b4e1783e15166ecff815f4ae736b10d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Tags_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PRO.Entities.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Zarządzaj słowami kluczowymi</h2>

<p>
    <div class=""btn btn-primary""><a class=""actionLinkManage"" href=""/tags/add"">Dodaj nowe</a></div>
    <div class=""btn btn-secondary""><a class=""actionLinkManage"" href=""/panel"">Powrót</a></div>
</p>
<table class=""table"">
    <tr>
        <th>
            ");
#nullable restore
#line 17 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
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
#line 29 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
               Write(Html.ActionLink("Edytuj", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
               Write(Html.ActionLink("Szczegóły", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
                     if (@User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
               Write(Html.ActionLink("Usuń", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
                                                                            
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td></td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<div>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
          
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
#line 61 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
          
            if (@current >= 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1904, "\"", 1948, 4);
            WriteAttributeValue("", 1911, "/tags/manage?page=", 1911, 18, true);
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 1929, first, 1929, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1935, "&items=", 1935, 7, true);
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 1942, items, 1942, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">«</a>\r\n                </li>\r\n");
#nullable restore
#line 67 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
            }
            if (@current >= 2 && @previous != @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2147, "\"", 2194, 4);
            WriteAttributeValue("", 2154, "/tags/manage?page=", 2154, 18, true);
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2172, previous, 2172, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2181, "&items=", 2181, 7, true);
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2188, items, 2188, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
                                                                                    Write(previous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2330, "\"", 2376, 4);
            WriteAttributeValue("", 2337, "/tags/manage?page=", 2337, 18, true);
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2355, current, 2355, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2363, "&items=", 2363, 7, true);
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2370, items, 2370, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
                                                                               Write(current);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 78 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"

            if (@last > @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2543, "\"", 2586, 4);
            WriteAttributeValue("", 2550, "/tags/manage?page=", 2550, 18, true);
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2568, next, 2568, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2573, "&items=", 2573, 7, true);
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2580, items, 2580, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
                                                                                Write(next);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 84 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
            }

            if (@last > @current + 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2773, "\"", 2816, 4);
            WriteAttributeValue("", 2780, "/tags/manage?page=", 2780, 18, true);
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2798, last, 2798, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2803, "&items=", 2803, 7, true);
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
WriteAttributeValue("", 2810, items, 2810, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n                </li>\r\n");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Tags\Manage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PRO.Entities.Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
