#pragma checksum "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0628ad9542e76155a4c45be3a654fcdbe940f712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_ExternalLogins), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
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
#line 1 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\_ViewImports.cshtml"
using PRO.UI.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\_ViewImports.cshtml"
using PRO.UI.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PRO.UI.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using PRO.UI.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/ExternalLogins")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0628ad9542e76155a4c45be3a654fcdbe940f712", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bec6919e47a087ca967818cce7a076aea707bb8", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d149f500460996045cf895af110e40716ec06a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbe212c8778c796007ade3e5f9a49bead248f9d", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Users/_TopUserBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("link-login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";
    ViewData["ActivePage"] = ManageNavPages.ExternalLogins;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0628ad9542e76155a4c45be3a654fcdbe940f7128148", async() => {
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
#line 11 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div id=\"content\" class=\"userprofilecontent\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0628ad9542e76155a4c45be3a654fcdbe940f71210110", async() => {
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
#line 16 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
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
            WriteLiteral(@"

    <div valign=""top"" style=""        padding-left: 5px;        display: flex;        width: 100%;"">
        <div class=""js-scrollfix-bottom-rel"" style=""display: flex; width: 100%;"">
            <div style="" margin:0 auto""></div><a name=""lower""></a>

            <table border=""0"" cellspacing=""0"" cellpadding=""0"" style=""display: inline-table; width: 100%;"">
                <tbody>
                    <tr>
                        <td style=""display: contents;"">
");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                             if (Model.CurrentLogins?.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"underlined_h2\">Połączone konta</div>\r\n                                <table class=\"table\">\r\n                                    <tbody>\r\n");
#nullable restore
#line 31 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                         foreach (var login in Model.CurrentLogins)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td");
            BeginWriteAttribute("id", " id=\"", 1399, "\"", 1446, 1);
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1404, $"login-provider-{login.LoginProvider}", 1404, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                               Write(login.ProviderDisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                     if (Model.ShowRemoveButton)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0628ad9542e76155a4c45be3a654fcdbe940f71214535", async() => {
                WriteLiteral("\r\n                                                            <div>\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0628ad9542e76155a4c45be3a654fcdbe940f71214927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0628ad9542e76155a4c45be3a654fcdbe940f71216903", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 41 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                <button type=\"submit\" class=\"btn btn-primary\"");
                BeginWriteAttribute("title", " title=\"", 2281, "\"", 2351, 7);
                WriteAttributeValue("", 2289, "Remove", 2289, 6, true);
                WriteAttributeValue(" ", 2295, "this", 2296, 5, true);
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 2300, login.ProviderDisplayName, 2301, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2327, "login", 2328, 6, true);
                WriteAttributeValue(" ", 2333, "from", 2334, 5, true);
                WriteAttributeValue(" ", 2338, "your", 2339, 5, true);
                WriteAttributeValue(" ", 2343, "account", 2344, 8, true);
                EndWriteAttribute();
                WriteLiteral(">Odłącz</button>\r\n                                                            </div>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
AddHtmlAttributeValue("", 1738, $"remove-login-{login.LoginProvider}", 1738, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            WriteLiteral(" &nbsp;\r\n");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 52 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n");
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                             if (Model.OtherLogins?.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"underlined_h2\">Połącz swoje konto</div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0628ad9542e76155a4c45be3a654fcdbe940f71223491", async() => {
                WriteLiteral("\r\n                                    <div id=\"socialLoginList\">\r\n                                        <p>\r\n");
#nullable restore
#line 62 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                             foreach (var provider in Model.OtherLogins)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <button");
                BeginWriteAttribute("id", " id=\"", 3670, "\"", 3714, 1);
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 3675, $"link-login-button-{provider.Name}", 3675, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 3769, "\"", 3791, 1);
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 3777, provider.Name, 3777, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3792, "\"", 3847, 6);
                WriteAttributeValue("", 3800, "Log", 3800, 3, true);
                WriteAttributeValue(" ", 3803, "in", 3804, 3, true);
                WriteAttributeValue(" ", 3806, "using", 3807, 6, true);
                WriteAttributeValue(" ", 3812, "your", 3813, 5, true);
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 3817, provider.DisplayName, 3818, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3839, "account", 3840, 8, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                                                                                                                                                                     Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n");
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </p>\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel>)PageContext?.ViewData;
        public ExternalLoginsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
