#pragma checksum "D:\PRO_Core\PRO\PRO\Views\ArticleTypes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1845a845ebab2af2771b347b34eb0670caea99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ArticleTypes_Delete), @"mvc.1.0.view", @"/Views/ArticleTypes/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1845a845ebab2af2771b347b34eb0670caea99e", @"/Views/ArticleTypes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_ArticleTypes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.ArticleType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\ArticleTypes\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2 class=""list-title box-shadow"">Usuń rodzaj artykułu</h2>
<div class=""window-background box-shadow p-3"">
    <h3>Czy na pewno chcesz usunąć ten rodzaj artykułu?</h3>
    <div>
        <hr />
        <dl class=""dl-horizontal"">
            <dt>
                ");
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\ArticleTypes\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 20 "D:\PRO_Core\PRO\PRO\Views\ArticleTypes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n        <hr />\r\n");
#nullable restore
#line 25 "D:\PRO_Core\PRO\PRO\Views\ArticleTypes\Delete.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\ArticleTypes\Delete.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""form-actions no-color"">
                <input type=""submit"" value=""Usuń"" class=""btn btn-primary"" />
                <a href=""#"" class=""btn btn-secondary"" onclick=""javascript:window.history.back(-1);return false;"">Powrót</a>
            </div>
");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\ArticleTypes\Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.ArticleType> Html { get; private set; }
    }
}
#pragma warning restore 1591
