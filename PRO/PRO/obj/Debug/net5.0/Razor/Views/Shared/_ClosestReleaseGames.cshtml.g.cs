#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c73060ad58577fc23c86df7c8aa06aea595ead2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ClosestReleaseGames), @"mvc.1.0.view", @"/Views/Shared/_ClosestReleaseGames.cshtml")]
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
using PRO.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
using PRO.Domain.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c73060ad58577fc23c86df7c8aa06aea595ead2", @"/Views/Shared/_ClosestReleaseGames.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4578dd96b4e1783e15166ecff815f4ae736b10d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ClosestReleaseGames : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PRO.Entities.Game>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"side-list-group\">\r\n    <h3 class=\"sidebar-title\">Nadchodzące premiery</h3>\r\n");
#nullable restore
#line 5 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
      
        var comingGames = Model.ToList().Take(3);

        foreach (var game in comingGames)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 308, 2);
            WriteAttributeValue("", 293, "/games/", 293, 7, true);
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
WriteAttributeValue("", 300, game.Id, 300, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action flex-column align-items-start\">\r\n                <div style=\"display:flex; flex-direction:row; overflow:hidden; text-overflow:clip;\">\r\n");
#nullable restore
#line 12 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
                     if (game.Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<img style=\"max-width: 50px;max-height: 50%;align-self: flex-start;flex-direction: row;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 666, "\"", 701, 2);
            WriteAttributeValue("", 672, "/images/", 672, 8, true);
#nullable restore
#line 13 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
WriteAttributeValue("", 680, game.Image.ImagePath, 680, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div style=\"padding-left: 15px;font-weight: 400;\">\r\n                        <div class=\"d-flex w-100 justify-content-between\">\r\n                            <h5 class=\"mb-1\">");
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
                                        Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <p class=\"mb-1\">");
#nullable restore
#line 20 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"
                                   Write(Html.Raw(@game.Description.Truncate(100)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</p>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </a>\r\n");
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Shared\_ClosestReleaseGames.cshtml"


        }
    

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PRO.Entities.Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
