#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993581727df57638814a231a9cd9022ae2638383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__UserLeftSide), @"mvc.1.0.view", @"/Views/Users/_UserLeftSide.cshtml")]
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
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
using PRO.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
using PRO.UI.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993581727df57638814a231a9cd9022ae2638383", @"/Views/Users/_UserLeftSide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__UserLeftSide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 20px; display:block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/ExternalLogins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"borderClass userprofile\" style=\"border-width: 0 1px 0 0;\" valign=\"top\">\r\n    <div class=\"userprofilebuttons\">\r\n\r\n        <div style=\"text-align: center;\">\r\n");
#nullable restore
#line 13 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
             if (Model.Image != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>\r\n                    <img style=\"max-width:200px;width: expression(this.width > 200 ? 200: true);\" class=\"lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 647, "\"", 683, 2);
            WriteAttributeValue("", 653, "/images/", 653, 8, true);
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 661, Model.Image.ImagePath, 661, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>");
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"clearfix mauto mt16\" style=\"width:160px;padding-right:10px\">\r\n        </div>\r\n        <div class=\"underlined_h2\">Dołączył: </div><p>");
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
                                                 Write(Model.RegisterDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <div class=\"underlined_h2\"></div>\r\n        <a style=\"margin: 20px; display:block;\"");
            BeginWriteAttribute("href", " href=\"", 1017, "\"", 1050, 2);
            WriteAttributeValue("", 1024, "/users/gamelists/", 1024, 17, true);
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 1041, Model.Id, 1041, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Gry użytkownika</a>\r\n        <a style=\"margin: 20px; display:block;\"");
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1179, 2);
            WriteAttributeValue("", 1153, "/users/userlists/", 1153, 17, true);
#nullable restore
#line 25 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 1170, Model.Id, 1170, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Listy użytkownika</a>\r\n");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
         if (ViewBag.IsOwner != null && ViewBag.IsOwner == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a style=\"margin: 20px; display:block;\"");
            BeginWriteAttribute("href", " href=\"", 1358, "\"", 1389, 3);
            WriteAttributeValue("", 1365, "/users/", 1365, 7, true);
#nullable restore
#line 28 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 1372, Model.Id, 1372, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1381, "/profile", 1381, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edytuj profil</a>\r\n            <a style=\"margin: 20px; display:block;\"");
            BeginWriteAttribute("href", " href=\"", 1485, "\"", 1517, 3);
            WriteAttributeValue("", 1492, "/users/", 1492, 7, true);
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 1499, Model.Id, 1499, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1508, "/password", 1508, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Zmień hasło</a>\r\n");
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
         if (hasExternalLogins)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "993581727df57638814a231a9cd9022ae26383839549", async() => {
                WriteLiteral("External logins");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix mauto mt16\" style=\"width:160px;padding-right:10px\">\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
