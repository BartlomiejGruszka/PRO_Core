#pragma checksum "D:\PRO_Core\PRO\PRO\Views\ControlPanel\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e194e1e1c71e022cf5615756d99aaf9c8aa65078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControlPanel_Admin), @"mvc.1.0.view", @"/Views/ControlPanel/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e194e1e1c71e022cf5615756d99aaf9c8aa65078", @"/Views/ControlPanel/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_ControlPanel_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Views\ControlPanel\Admin.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" class=""top-ranking-table"">
    <tbody>
        <tr class=""table-header top-game-rank-text manage""><td class=""rank ac"" style=""font-size:24px;"">Panel admina</td></tr>

        <tr class=""ranking-list"">
            <td class=""rank ac"" valign=""top"">
                <span class=""lightLink top-game-rank-text manage""><a href=""/panel/admin/games"">Dane gier</a></span>
            </td>
        </tr>
        <tr class=""ranking-list"">
            <td class=""rank ac"" valign=""top"">
                <span class=""lightLink top-game-rank-text manage""><a href=""/panel/admin/articles"">Dane artykułów</a></span>
            </td>
        </tr>
        <tr class=""ranking-list"">
            <td class=""rank ac"" valign=""top"">
                <span class=""lightLink top-game-rank-text manage""><a href=""/panel/admin/users"">Dane użytkowników</a></span>
            </td>
        </tr>  
    </tbody>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591