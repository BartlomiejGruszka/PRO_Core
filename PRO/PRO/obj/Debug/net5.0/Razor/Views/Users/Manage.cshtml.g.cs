#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c8743d1f45f6c8bdfbf45c61a207fb0949f0bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Manage), @"mvc.1.0.view", @"/Views/Users/Manage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c8743d1f45f6c8bdfbf45c61a207fb0949f0bf", @"/Views/Users/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PRO.Entities.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
  
    ViewBag.Title = "Manage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Zarządzaj użytkownikami</h2>\r\n\r\n<p>\r\n");
#nullable restore
#line 11 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"btn btn-primary\"><a class=\"actionLinkManage\" href=\"/users/add\">Dodaj nowego</a></div>\r\n");
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"btn btn-secondary\"><a class=\"actionLinkManage\" href=\"/panel\">Powrót</a></div>\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       Write(Html.Label("Nazwa użytkownika"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       Write(Html.DisplayNameFor(model => model.RegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 35 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       Write(Html.DisplayNameFor(model => model.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       var start = ViewBag.Pagination.pageIteratorStart;
        var end = ViewBag.Pagination.pageIteratorEnd;
        for (var i = start; i <= end; i++)
        {
            var item = Model.ToArray()[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n");
#nullable restore
#line 47 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                      if (item.Image != null)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"text-align: center;\">\r\n                                <img style=\"max-height:200px;max-width:100px;width: expression(this.width > 100 ? 100: true);\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 1551, "\"", 1586, 2);
            WriteAttributeValue("", 1557, "/images/", 1557, 8, true);
#nullable restore
#line 51 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 1565, item.Image.ImagePath, 1565, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak obrazu</p>");
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                            }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.RegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Edytuj", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Szczegóły", "ManageDetails", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                     if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 80 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Usuń", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                            ;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Zmień hasło", "ChangePassword", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                           ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 87 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"

            /**/
            /**/
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<div>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
          
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
#line 116 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
          
            if (@current >= 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3652, "\"", 3697, 4);
            WriteAttributeValue("", 3659, "/users/manage?page=", 3659, 19, true);
#nullable restore
#line 120 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 3678, first, 3678, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3684, "&items=", 3684, 7, true);
#nullable restore
#line 120 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 3691, items, 3691, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">«</a>\r\n                </li>\r\n");
#nullable restore
#line 122 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
            }
            if (@current >= 2 && @previous != @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3896, "\"", 3944, 4);
            WriteAttributeValue("", 3903, "/users/manage?page=", 3903, 19, true);
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 3922, previous, 3922, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3931, "&items=", 3931, 7, true);
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 3938, items, 3938, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                     Write(previous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 128 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4080, "\"", 4127, 4);
            WriteAttributeValue("", 4087, "/users/manage?page=", 4087, 19, true);
#nullable restore
#line 131 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 4106, current, 4106, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4114, "&items=", 4114, 7, true);
#nullable restore
#line 131 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 4121, items, 4121, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 131 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                Write(current);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 133 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"

            if (@last > @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4294, "\"", 4338, 4);
            WriteAttributeValue("", 4301, "/users/manage?page=", 4301, 19, true);
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 4320, next, 4320, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4325, "&items=", 4325, 7, true);
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 4332, items, 4332, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                 Write(next);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 139 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
            }

            if (@last > @current + 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4525, "\"", 4569, 4);
            WriteAttributeValue("", 4532, "/users/manage?page=", 4532, 19, true);
#nullable restore
#line 144 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 4551, last, 4551, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4556, "&items=", 4556, 7, true);
#nullable restore
#line 144 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 4563, items, 4563, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n                </li>\r\n");
#nullable restore
#line 146 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PRO.Entities.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591