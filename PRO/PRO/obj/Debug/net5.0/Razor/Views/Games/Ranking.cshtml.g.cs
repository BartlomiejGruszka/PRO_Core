#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f10dad74d49324052089578e24fd3de9884d648"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Ranking), @"mvc.1.0.view", @"/Views/Games/Ranking.cshtml")]
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
#line 2 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
using PRO.Domain.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
using PRO.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f10dad74d49324052089578e24fd3de9884d648", @"/Views/Games/Ranking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Ranking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.GameFilterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
  
    ViewBag.Title = "Ranking";
    Layout = "~/Views/Shared/_Layout.cshtml";
    bool userLoggedIn = (SignInManager.IsSignedIn(User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
 using (Html.BeginForm("FilterRanking", "Games"))
{
    /*<div class="form-group">
        @Html.LabelFor(l=>l.Platforms)
    </div>*/
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" class=""top-ranking-table"">
        <tbody>
            <tr class=""table-header"">
                <td class=""rank"">Ranga</td>
                <td class=""title"">Tytuł</td>
                <td class=""release-date"">Data premiery</td>
");
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                   if (userLoggedIn)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"your-score\">Twoja ocena</td>\r\n");
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"score\">Średnia ocena</td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
              
                var start = ViewBag.Pagination.pageIteratorStart;
                var end = ViewBag.Pagination.pageIteratorEnd;
                var scores = Model.GameScores.ToArray();
                for (var i = start; i <= end; i++)
                {

                    var game = scores[i].Item1;
                    var score = scores.Where(g => g.Item1.Id == game.Id).SingleOrDefault();



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"ranking-list\">\r\n                        <td class=\"rank ac\" valign=\"top\">\r\n                            <span class=\"lightLink top-game-rank-text rank1\">");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                         Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td class=\"title al va-t word-break\">\r\n                            <div class=\"gameListImageGrid\">\r\n                                <div>\r\n");
#nullable restore
#line 51 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                     if (game.Image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"fl-l ml12 mr8\"");
            BeginWriteAttribute("href", " href=\"", 2046, "\"", 2068, 2);
            WriteAttributeValue("", 2053, "/games/", 2053, 7, true);
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 2060, game.Id, 2060, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"position: relative;\">\r\n                                            <img width=\"70\" height=\"90\" class=\" lazyloaded\" border=\"0\"");
            BeginWriteAttribute("src", " src=\"", 2202, "\"", 2237, 2);
            WriteAttributeValue("", 2208, "/images/", 2208, 8, true);
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 2216, game.Image.ImagePath, 2216, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n\r\n                                <div class=\"detail\">\r\n                                    <div class=\"di-flex clearfix\">\r\n                                        <a");
            BeginWriteAttribute("class", " class=\"", 2532, "\"", 2540, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2541, "\"", 2563, 2);
            WriteAttributeValue("", 2548, "/games/", 2548, 7, true);
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 2555, game.Id, 2555, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                      Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n                                    <div class=\"information di-ib mt4\" style=\"overflow:hidden; text-overflow:clip; max-width:500px; min-width:200px;\">\r\n                                        ");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                   Write(Html.Raw(@game.Description.Truncate(140)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...<a");
            BeginWriteAttribute("href", " href=\"", 2865, "\"", 2887, 2);
            WriteAttributeValue("", 2872, "/games/", 2872, 7, true);
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 2879, game.Id, 2879, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">więcej</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </td>\r\n                        <td class=\"status ac\">\r\n");
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                             if (game.ReleaseDate.HasValue)
                            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                        Write(game.ReleaseDate.Value.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                 Write(game.ReleaseDate.Value.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                                            Write(game.ReleaseDate.Value.Year);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                                                                             }
                        else
                        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("brak daty");
#nullable restore
#line 74 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                          if (userLoggedIn)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <td class=""your-score ac fs14"">
                                    <div class=""js-top-ranking-your-score-col di-ib al"" style=""width: 43.4063px;"">
                                        <i class=""icon-score-star mr4 ""></i><span class=""text  score-label score-na"">N/A</span>
                                    </div>
                                </td>
");
#nullable restore
#line 84 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td class=""score ac fs14"">
                            <div class=""js-top-ranking-score-col di-ib al"" style=""width: 48.7969px;"">
                                <i class=""icon-score-star mr4 on""></i>
                                <span class=""text on score-label score-9"">
");
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                      
                                        if (score.Item2.HasValue && !Double.IsNaN(score.Item2.Value))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                       Write(Math.Round((double)score.Item2, 1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                               
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            WriteLiteral("0\r\n");
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 103 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 110 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
          
            var first = ViewBag.Pagination.firstPage;
            var current = ViewBag.Pagination.currentPage;
            var previous = ViewBag.Pagination.previousPage;
            var items = ViewBag.Pagination.itemsPerPage;
            var next = ViewBag.Pagination.nextPage;
            var last = ViewBag.Pagination.lastPage;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 122 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
          
            if (@current >= 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5509, "\"", 5555, 4);
            WriteAttributeValue("", 5516, "/games/ranking?page=", 5516, 20, true);
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 5536, first, 5536, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5542, "&items=", 5542, 7, true);
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 5549, items, 5549, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">«</a>\r\n                </li>\r\n");
#nullable restore
#line 128 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
            }
            if (@current >= 2 && @previous != @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5754, "\"", 5803, 4);
            WriteAttributeValue("", 5761, "/games/ranking?page=", 5761, 20, true);
#nullable restore
#line 132 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 5781, previous, 5781, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5790, "&items=", 5790, 7, true);
#nullable restore
#line 132 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 5797, items, 5797, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 132 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                      Write(previous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 134 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5939, "\"", 5987, 4);
            WriteAttributeValue("", 5946, "/games/ranking?page=", 5946, 20, true);
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 5966, current, 5966, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5974, "&items=", 5974, 7, true);
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 5981, items, 5981, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 137 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                 Write(current);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 139 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"

            if (@last > @current)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6154, "\"", 6199, 4);
            WriteAttributeValue("", 6161, "/games/ranking?page=", 6161, 20, true);
#nullable restore
#line 143 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 6181, next, 6181, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6186, "&items=", 6186, 7, true);
#nullable restore
#line 143 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 6193, items, 6193, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 143 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                  Write(next);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 145 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
            }

            if (@last > @current + 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6386, "\"", 6431, 4);
            WriteAttributeValue("", 6393, "/games/ranking?page=", 6393, 20, true);
#nullable restore
#line 150 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 6413, last, 6413, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6418, "&items=", 6418, 7, true);
#nullable restore
#line 150 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 6425, items, 6425, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n                </li>\r\n");
#nullable restore
#line 152 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.GameFilterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
