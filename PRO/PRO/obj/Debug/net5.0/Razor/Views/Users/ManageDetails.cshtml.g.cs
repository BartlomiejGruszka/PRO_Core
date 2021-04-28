#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25e16f0ff64448d74325d2e2eae42013aad47499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ManageDetails), @"mvc.1.0.view", @"/Views/Users/ManageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25e16f0ff64448d74325d2e2eae42013aad47499", @"/Views/Users/ManageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ManageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Szczegóły użytkownika</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Login\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            Email\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n\r\n");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
              if (Model.Image != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"text-align: center;\">\r\n                        <img style=\"max-height:200px;max-width:100px;width: expression(this.width > 100 ? 100: true);\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 838, "\"", 879, 1);
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
WriteAttributeValue("", 844, Url.Content(Model.Image.ImagePath), 844, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak obrazu</p>");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
                                    }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.RegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 52 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayFor(model => model.RegisterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 59 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 62 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
       Write(Html.DisplayFor(model => model.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    <div class=\"btn btn-primary\"><a class=\"actionLinkManage\"");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1833, 2);
            WriteAttributeValue("", 1812, "/users/edit/", 1812, 12, true);
#nullable restore
#line 79 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
WriteAttributeValue("", 1824, Model.Id, 1824, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a></div>\r\n");
#nullable restore
#line 80 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
     if (User.IsInRole("Admin")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"btn btn-primary\"><a class=\"actionLinkManage\"");
            BeginWriteAttribute("href", " href=\"", 1953, "\"", 1991, 2);
            WriteAttributeValue("", 1960, "/users/changePassword/", 1960, 22, true);
#nullable restore
#line 81 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
WriteAttributeValue("", 1982, Model.Id, 1982, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Zmień hasło</a></div> \r\n");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Users\ManageDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"#\" class=\"btn btn-secondary\" onclick=\"javascript:window.history.back(-1);return false;\">Powrót</a>\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
