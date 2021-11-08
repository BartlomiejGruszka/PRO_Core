#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d032d6a1c70487628b986632f4071cbc316ab1f1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d032d6a1c70487628b986632f4071cbc316ab1f1", @"/Views/Users/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.PaginatedList<PRO.Entities.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex; align-items: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_Pagination.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
    <div class=""container-fluid"">
        <a class=""navbar-brand"" href=""/users/manage"">Zarządzaj użytkownikami</a>
        <button onclick=""openButton2()"" class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarColor02"" aria-controls=""navbarColor02"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarColor02"" style="" align-items: start; justify-content: flex-end;"">
            <ul class=""navbar-nav me-auto"">
");
#nullable restore
#line 17 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                 if (User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" href=\"/users/add\">\r\n                            Dodaj\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" href=\"/panel\">Powrót</a>\r\n                </li>\r\n            </ul>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d032d6a1c70487628b986632f4071cbc316ab1f16769", async() => {
                WriteLiteral("\r\n                <input class=\"form-control me-sm-2\" placeholder=\"Szukaj\" type=\"text\" name=\"query\"");
                BeginWriteAttribute("value", " value=\"", 1433, "\"", 1467, 1);
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 1441, ViewData["CurrentFilter"], 1441, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <button class=\"btn btn-secondary my-2 my-sm-0\" style=\"margin-left:5px;\" type=\"submit\">Szukaj</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</nav>\r\n<div class=\"table-container\">\r\n    <table class=\"table\">\r\n        <tr class=\"tableheadercolor\">\r\n            <th>\r\n                Obraz\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d032d6a1c70487628b986632f4071cbc316ab1f19427", async() => {
                WriteLiteral("Użytkownik");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                WriteLiteral(ViewData["UserSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                                    WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d032d6a1c70487628b986632f4071cbc316ab1f112432", async() => {
                WriteLiteral("Email");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                WriteLiteral(ViewData["EmailSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                                     WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d032d6a1c70487628b986632f4071cbc316ab1f115439", async() => {
                WriteLiteral("Data dodania");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                WriteLiteral(ViewData["AddDateSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                                       WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d032d6a1c70487628b986632f4071cbc316ab1f118457", async() => {
                WriteLiteral("Data edycji");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                WriteLiteral(ViewData["EditDateSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                                        WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Aktywny\r\n            </th>\r\n            <th>\r\n                Publiczny\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
           foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tablerow\">\r\n                    <td>\r\n");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                          if (item.Image != null)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div style=\"text-align: center;\">\r\n                                    <img style=\"max-height:70px;max-width:70px;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 3125, "\"", 3160, 2);
            WriteAttributeValue("", 3131, "/images/", 3131, 8, true);
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
WriteAttributeValue("", 3139, item.Image.ImagePath, 3139, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n");
#nullable restore
#line 75 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak obrazu</p>");
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 92 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                         if (item.EditDate.HasValue)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                    Write(Html.DisplayFor(modelItem => item.EditDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                     }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>brak</p>");
#nullable restore
#line 95 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 99 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 102 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 105 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.ActionLink("Edytuj", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 106 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.ActionLink("Szczegóły", "ManageDetails", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 107 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 109 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.ActionLink("Usuń", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                ;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("|");
#nullable restore
#line 111 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                   Write(Html.ActionLink("Zmień hasło", "ChangePassword", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
                                                                                               ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 116 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d032d6a1c70487628b986632f4071cbc316ab1f127951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 123 "D:\PRO_Core\PRO\PRO\Views\Users\Manage.cshtml"
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
            WriteLiteral("\r\n</div>\r\n<script>\r\n    function openButton2() {\r\n        var element = document.getElementById(\"navbarColor02\");\r\n        element.classList.toggle(\"collapse\");\r\n    }\r\n\r\n</script>\r\n");
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
