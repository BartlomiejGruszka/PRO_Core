#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb6183b1e2470661f244d5670c21bfe396a75bff"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb6183b1e2470661f244d5670c21bfe396a75bff", @"/Views/Users/_UserLeftSide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__UserLeftSide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.UserProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"borderClass userprofile\" style=\"border-width: 0 1px 0 0;\" valign=\"top\">\r\n    <div class=\"userprofilebuttons\">\r\n\r\n        <div style=\"text-align: center;\">\r\n");
#nullable restore
#line 7 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
             if (Model.ApplicationUser.Image != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>\r\n                    <img style=\"max-width:200px;width: expression(this.width > 200 ? 200: true);\" class=\"lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 406, "\"", 458, 2);
            WriteAttributeValue("", 412, "/images/", 412, 8, true);
#nullable restore
#line 9 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 420, Model.ApplicationUser.Image.ImagePath, 420, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>");
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"clearfix mauto mt16\" style=\"width:160px;padding-right:10px\">\r\n        </div>\r\n        <div class=\"underlined_h2\">Dołączył: </div><p>");
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
                                                 Write(Model.ApplicationUser.RegisterDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <div class=\"underlined_h2\"></div>\r\n        <a style=\"margin: 20px; display:block;\" href=\"#\" class=\"btn btn-secondary\">Listy użytkownika</a>\r\n");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
         if (User.Identity.IsAuthenticated && Model.LoggedUserId == Model.ApplicationUser.Id)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a style=\"margin: 20px; display:block;\"");
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1051, 3);
            WriteAttributeValue("", 1011, "/users/", 1011, 7, true);
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 1018, Model.ApplicationUser.Id, 1018, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1043, "/profile", 1043, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edytuj profil</a>\r\n            <a style=\"margin: 20px; display:block;\"");
            BeginWriteAttribute("href", " href=\"", 1147, "\"", 1195, 3);
            WriteAttributeValue("", 1154, "/users/", 1154, 7, true);
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
WriteAttributeValue("", 1161, Model.ApplicationUser.Id, 1161, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1186, "/password", 1186, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Zmień hasło</a>\r\n");
#nullable restore
#line 23 "D:\PRO_Core\PRO\PRO\Views\Users\_UserLeftSide.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"clearfix mauto mt16\" style=\"width:160px;padding-right:10px\">\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
