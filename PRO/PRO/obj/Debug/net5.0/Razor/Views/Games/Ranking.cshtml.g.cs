#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b04f7f885622392257a750ab11a887ce4d049bb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b04f7f885622392257a750ab11a887ce4d049bb", @"/Views/Games/Ranking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Ranking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.GameFilterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_Pagination.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""window-background box-shadow"">
    <div class=""table-container"">
        <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" class=""top-ranking-table table"">
            <tbody>
                <tr class=""table-header"">
                    <td class=""rank"">Ranga</td>
                    <td class=""title"">Tytuł</td>
                    <td class=""title"">Platforma</td>
                    <td class=""release-date"">Data premiery</td>
");
#nullable restore
#line 28 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                       if (userLoggedIn)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"your-score\">Twoja ocena</td>\r\n");
#nullable restore
#line 31 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"score\">Średnia ocena</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                  
                    int i = ((Model.GamesScores.Pagination.PageIndex - 1) * Model.GamesScores.Pagination.PageItems);
                    foreach (var item in Model.GamesScores)

                    {
                        i = i + 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"ranking-list tablerow\">\r\n                            <td class=\"rank ac\" valign=\"top\">\r\n                                <span class=\"lightLink top-game-rank-text rank1\">");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </td>\r\n                            <td class=\"title al va-t word-break\">\r\n                                <div class=\"gameListImageGrid\">\r\n                                    <div>\r\n");
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                         if (item.Game.Image != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"fl-l ml12 mr8\"");
            BeginWriteAttribute("href", " href=\"", 2113, "\"", 2140, 2);
            WriteAttributeValue("", 2120, "/games/", 2120, 7, true);
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 2127, item.Game.Id, 2127, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"position: relative;\">\r\n                                                <img width=\"70\" height=\"90\" class=\" lazyloaded\" border=\"0\"");
            BeginWriteAttribute("src", " src=\"", 2278, "\"", 2318, 2);
            WriteAttributeValue("", 2284, "/images/", 2284, 8, true);
#nullable restore
#line 51 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 2292, item.Game.Image.ImagePath, 2292, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </a>\r\n");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n\r\n                                    <div class=\"detail\">\r\n                                        <div class=\"di-flex clearfix\">\r\n                                            <a");
            BeginWriteAttribute("class", " class=\"", 2637, "\"", 2645, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2646, "\"", 2673, 2);
            WriteAttributeValue("", 2653, "/games/", 2653, 7, true);
#nullable restore
#line 58 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 2660, item.Game.Id, 2660, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                               Write(item.Game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <div class=\"information di-ib mt4\" style=\"overflow:hidden; text-overflow:clip; max-width:500px; min-width:200px;\">\r\n                                            ");
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                       Write(Html.Raw(item.Game.Description.Truncate(140)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...<a");
            BeginWriteAttribute("href", " href=\"", 2996, "\"", 3023, 2);
            WriteAttributeValue("", 3003, "/games/", 3003, 7, true);
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
WriteAttributeValue("", 3010, item.Game.Id, 3010, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">więcej</a>
                                        </div>
                                    </div>
                                </div>

                            </td>
                            <td style=""text-align:center;"">
                                <div>
");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                     if (item.Game.Platform.Name != null)
                                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                Write(item.Game.Platform.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                              }
                                else
                                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </td>\r\n                            <td class=\"status ac\">\r\n");
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                 if (item.Game.ReleaseDate.HasValue)
                                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                            Write(item.Game.ReleaseDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                 }
                            else
                            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 79 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                              if (userLoggedIn)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"ac fs14\">\r\n                                        <div class=\"js-top-ranking-your-score-col di-ib al\" style=\"width: 43.4063px;\">\r\n");
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                              
                                                var userscore = "";
                                                if (item.UserScore != null)
                                                    userscore = item.UserScore.ToString();
                                                else
                                                    userscore = "Brak";
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"icon-score-star mr4 \"></i><span class=\"text  score-label score-na\">");
#nullable restore
#line 93 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                                                    Write(userscore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </td>\r\n");
#nullable restore
#line 96 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <td class=""score ac fs14"">
                                <div class=""js-top-ranking-score-col di-ib al"" style=""width: 48.7969px;"">
                                    <i class=""icon-score-star mr4 on""></i>
                                    <span class=""text on score-label score-9"">
");
#nullable restore
#line 101 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                          
                                            if (item.Score.HasValue && !Double.IsNaN(item.Score.Value))
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                           Write(Math.Round((double)item.Score, 1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                                                                  
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            WriteLiteral("-\r\n");
#nullable restore
#line 109 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 115 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b04f7f885622392257a750ab11a887ce4d049bb16257", async() => {
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
#line 121 "D:\PRO_Core\PRO\PRO\Views\Games\Ranking.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.GamesScores.Pagination;

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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
