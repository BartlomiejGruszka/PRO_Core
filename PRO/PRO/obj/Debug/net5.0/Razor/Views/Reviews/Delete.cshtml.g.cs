#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab3f4cd943aa83ed45eb392b68e5d001a077a9b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Delete), @"mvc.1.0.view", @"/Views/Reviews/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3f4cd943aa83ed45eb392b68e5d001a077a9b8", @"/Views/Reviews/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Usuń recenzję</h2>\r\n\r\n<h3>Czy na pewno chcesz usunąć tę recenzję?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Game));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Game.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Moderator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Moderator.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GraphicsScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GraphicsScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 58 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StoryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 62 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StoryScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 66 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MusicScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 70 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MusicScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 74 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GameplayScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 78 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GameplayScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 83 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-actions no-color"">
            <input type=""submit"" value=""Usuń"" class=""btn btn-primary"" />
            <a href=""#"" class=""btn btn-secondary"" onclick=""javascript:window.history.back(-1);return false;"">Powrót</a>
        </div>
");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Reviews\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
