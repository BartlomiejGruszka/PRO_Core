#pragma checksum "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a195003674c121ded66f029c844b1a131ae24a30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserLists), @"mvc.1.0.view", @"/Views/Users/UserLists.cshtml")]
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
#line 1 "D:\Repo_PRO\PRO\PRO\Views\_ViewImports.cshtml"
using PRO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repo_PRO\PRO\PRO\Views\_ViewImports.cshtml"
using PRO.UI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
using PRO.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a195003674c121ded66f029c844b1a131ae24a30", @"/Views/Users/UserLists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_UserLists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.UserUserListsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Users/_TopUserBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Users/_UserLeftSide.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link sort"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserLists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
  
    ViewBag.Title = "Profil użytkownika";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"box-shadow\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a195003674c121ded66f029c844b1a131ae24a305166", async() => {
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
#line 8 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.AppUser;

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
            WriteLiteral("\r\n</div>\r\n<div id=\"content\" class=\"userprofilecontent box-shadow window-background\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a195003674c121ded66f029c844b1a131ae24a307109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 11 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.AppUser;

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
            WriteLiteral("\r\n    <div style=\" width: 100%; padding:10px;\">\r\n\r\n        <div id=\"status-menu\" class=\"status-menu-container\">\r\n            <div class=\"status-menu\">\r\n");
#nullable restore
#line 16 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                   var selectedlist = "all";
                    if (Model.UserLists.Pagination.CurrentFilter != null) { selectedlist = Model.UserLists.Pagination.CurrentFilter.ToString(); } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 804, "\"", 863, 3);
            WriteAttributeValue("", 811, "/users/userlists/", 811, 17, true);
#nullable restore
#line 18 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue("", 828, Model.AppUser.Id, 828, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 845, "?currentFilter=all", 845, 18, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 864, "\"", 927, 2);
            WriteAttributeValue("", 872, "status-button", 872, 13, true);
#nullable restore
#line 18 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue(" ", 885, selectedlist.Equals("all") ? "on" : "", 886, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Wszystkie listy</a>\r\n");
#nullable restore
#line 19 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                  foreach (ListType list in Model.ListTypes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1061, "\"", 1127, 4);
            WriteAttributeValue("", 1068, "/users/userlists/", 1068, 17, true);
#nullable restore
#line 21 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue("", 1085, Model.AppUser.Id, 1085, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1102, "?currentFilter=", 1102, 15, true);
#nullable restore
#line 21 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue("", 1117, list.Name, 1117, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1128, "\"", 1195, 2);
            WriteAttributeValue("", 1136, "status-button", 1136, 13, true);
#nullable restore
#line 21 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue(" ", 1149, selectedlist.Equals(list.Name) ? "on" : "", 1150, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                                             Write(list.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 22 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"list-block\">\r\n\r\n            <div class=\"list-unit\">\r\n                <div class=\"list-status-title\">\r\n                    <span class=\"text\">\r\n");
#nullable restore
#line 31 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                         if (selectedlist == "all")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Wszystkie listy</span>");
#nullable restore
#line 32 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                     }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 34 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                           Write(selectedlist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 34 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n");
#nullable restore
#line 36 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                     if (Model.LoggedUserId.HasValue && Model.LoggedUserId.Value != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a  style=\"margin:10px;\" href=\"/users/userlist\" class=\"btn btn-secondary\">\r\n                            Dodaj\r\n                        </a>");
#nullable restore
#line 40 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <table class=\"list-table\">\r\n                    <tbody>\r\n                        <tr class=\"list-table-header\">\r\n                            <th class=\"header-title\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a195003674c121ded66f029c844b1a131ae24a3014469", async() => {
                WriteLiteral("Nazwa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                     WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                         WriteLiteral(Model.UserLists.Pagination.CurrentFilter);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                                                                                     WriteLiteral(Model.UserLists.Pagination.PageItems);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["items"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-items", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["items"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                                                                                                                                            WriteLiteral(Model.UserLists.Pagination.PageIndex);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </th>
                            <th class=""header-title"">
                                <span class=""link sort"">
                                    Typ listy
                                </span>
                            </th>
                            <th class=""header-title"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a195003674c121ded66f029c844b1a131ae24a3019730", async() => {
                WriteLiteral("Gier na liście");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                     WriteLiteral(ViewData["CountSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                          WriteLiteral(Model.UserLists.Pagination.CurrentFilter);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                                                                                      WriteLiteral(Model.UserLists.Pagination.PageItems);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["items"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-items", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["items"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                                                                                                                                             WriteLiteral(Model.UserLists.Pagination.PageIndex);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 58 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                             if (ViewBag.IsOwner)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <th class=""header-title"">
                                    <span class=""link sort"">
                                        Publiczna
                                    </span>
                                </th>
                                <th class=""header-title"">
                                    <span class=""link sort"">
                                        
                                    </span>
                                </th>
                                <th class=""header-title"">
                                    <span class=""link sort"">
                                        
                                    </span>
                                </th>
");
#nullable restore
#line 75 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 78 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                       int index = ((Model.UserLists.Pagination.PageIndex - 1) * Model.UserLists.Pagination.PageItems);
                        foreach (var item in Model.UserLists)
                        {
                            index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody class=\"list-item\">\r\n                                <tr class=\"list-table-data\">\r\n                                    <td class=\"data title clearfix\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4567, "\"", 4653, 4);
            WriteAttributeValue("", 4574, "/users/gamelists/", 4574, 17, true);
#nullable restore
#line 85 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue("", 4591, Model.AppUser.Id, 4591, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4608, "?filterType=ListName&currentFilter=", 4608, 35, true);
#nullable restore
#line 85 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue("", 4643, item.Name, 4643, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link sort\">");
#nullable restore
#line 85 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </td>\r\n                                    <td class=\"data score\">\r\n                                        <span class=\"score-label score-na\">\r\n                                            ");
#nullable restore
#line 89 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                       Write(item.ListType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n                                    </td>\r\n                                    <td class=\"data score\">\r\n                                        <span class=\"score-label score-na\">\r\n");
#nullable restore
#line 94 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                             if (item.GameLists?.Count() == null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>-</span> ");
#nullable restore
#line 95 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                            }
                                            else
                                            { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                         Write(item.GameLists.Count());

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </span>\r\n                                    </td>\r\n");
#nullable restore
#line 100 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                     if (ViewBag.IsOwner)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"data\">\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 5730, "\"", 5738, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 104 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                           Write(Html.CheckBoxFor(model => item.IsPublic, new { @disabled = "disabled", @class = "link sort" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                        <td class=\"data\">\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 6093, "\"", 6101, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6155, "\"", 6186, 2);
            WriteAttributeValue("", 6162, "/users/userlist/", 6162, 16, true);
#nullable restore
#line 109 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue("", 6178, item.Id, 6178, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""link sort"">
                                                    Edytuj
                                                </a>
                                            </div>
                                        </td>
                                        <td class=""data"">
                                            <div");
            BeginWriteAttribute("class", " class=\"", 6528, "\"", 6536, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6590, "\"", 6628, 2);
            WriteAttributeValue("", 6597, "/users/userlist/delete/", 6597, 23, true);
#nullable restore
#line 116 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
WriteAttributeValue("", 6620, item.Id, 6620, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link sort\">\r\n                                                    Usuń\r\n                                                </a>\r\n                                            </div>\r\n                                        </td>\r\n");
#nullable restore
#line 121 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                            </tbody>\r\n");
#nullable restore
#line 124 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a195003674c121ded66f029c844b1a131ae24a3032955", async() => {
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
#line 128 "D:\Repo_PRO\PRO\PRO\Views\Users\UserLists.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.UserLists.Pagination;

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.UserUserListsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
