#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354216d79bf574c1d2caea9ae60f91f91ea05c88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Manage), @"mvc.1.0.view", @"/Views/Games/Manage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354216d79bf574c1d2caea9ae60f91f91ea05c88", @"/Views/Games/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.PaginatedList<PRO.Entities.Game>>
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
#line 3 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
  
    ViewBag.Title = "Manage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Zarządzaj grami</h2>

<p>
    <div class=""btn btn-primary""><a class=""actionLinkManage"" href=""/games/add"">Dodaj nową</a></div>
    <div class=""btn btn-secondary""><a class=""actionLinkManage"" href=""/panel"">Powrót</a></div>
</p>
<table class=""table"">
    <tr>
        <th>
           Tytuł
        </th>
        <th>
            Pltforma
        </th>
        <th>
           Status
        </th>
        <th>
            Data wydania
        </th>
        <th>
           Gatunek
        </th>
        <th>
            Producent
        </th>
        <th>
            Wydawca
        </th>
        <th>
            Seria
        </th>
        <th>
            Dostępna
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
      foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Platform.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 60 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                     if (item.ReleaseDate != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                                                       

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak</p>");
#nullable restore
#line 66 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                     if (item.DeveloperCompany != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DeveloperCompany.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                                                                 

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak</p>");
#nullable restore
#line 78 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                     if (item.PublisherCompany != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PublisherCompany.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                                                                 

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak</p>");
#nullable restore
#line 88 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                     if (item.Series != null) { 
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Series.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                                                       

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak</p>");
#nullable restore
#line 96 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 100 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 103 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.ActionLink("Edytuj", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.ActionLink("Szczegóły", "ManageDetails", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                                                                          if (@User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 106 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
               Write(Html.ActionLink("Usuń", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
                                                                            
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 110 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n<div>\r\n");
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
      Model.Pagination.Route = "games/manage?";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "354216d79bf574c1d2caea9ae60f91f91ea05c8812073", async() => {
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
#line 127 "D:\PRO_Core\PRO\PRO\Views\Games\Manage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.PaginatedList<PRO.Entities.Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
