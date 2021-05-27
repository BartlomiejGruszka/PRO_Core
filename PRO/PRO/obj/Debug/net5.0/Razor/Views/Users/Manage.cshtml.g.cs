#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e919142a089cd3d3d12c3cd80425dd41ad237ef6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e919142a089cd3d3d12c3cd80425dd41ad237ef6", @"/Views/Users/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.PaginatedList<PRO.Entities.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_Pagination.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
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
            WriteLiteral("    <div class=\"btn btn-secondary\"><a class=\"actionLinkManage\" href=\"/panel\">Powrót</a></div>\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            Obraz\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       Write(Html.Label("Nazwa użytkownika"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </th>
        <th>
            Email
        </th>
        <th>
            Data rejestracji
        </th>
        <th>
            Aktywny
        </th>
        <th>
            Publiczny
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
       foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n");
#nullable restore
#line 44 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                      if (item.Image != null)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"text-align: center;\">\r\n                                <img style=\"max-height:70px;max-width:70px;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 1170, "\"", 1205, 2);
            WriteAttributeValue("", 1176, "/images/", 1176, 8, true);
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 1184, item.Image.ImagePath, 1184, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak obrazu</p>");
#nullable restore
#line 52 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                            }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.RegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Edytuj", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 74 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Szczegóły", "ManageDetails", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                     if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Usuń", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                            ;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 79 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
               Write(Html.ActionLink("Zmień hasło", "ChangePassword", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                           ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 84 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"

            /**/
            /**/
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<div>\r\n");
#nullable restore
#line 100 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
      Model.Pagination.Route = "users/manage?";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e919142a089cd3d3d12c3cd80425dd41ad237ef610340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 101 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Pagination;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.PaginatedList<PRO.Entities.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
