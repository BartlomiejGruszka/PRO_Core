#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94696399810d23d20396a565805e6fda8d85e1e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Details), @"mvc.1.0.view", @"/Views/Games/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94696399810d23d20396a565805e6fda8d85e1e2", @"/Views/Games/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.GameDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_GameTitleBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_GameInfoBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_SingleReview.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94696399810d23d20396a565805e6fda8d85e1e24216", async() => {
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
#line 8 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.GameGameList.Game;

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
            WriteLiteral("\r\n<div id=\"content\">\r\n\r\n    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\">\r\n        <tbody>\r\n            <tr>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94696399810d23d20396a565805e6fda8d85e1e26233", async() => {
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
#line 14 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.GameGameList;

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
                <td valign=""top"" style=""padding-left: 5px;"">
                    <div class=""js-scrollfix-bottom-rel"">
                        <div style="" margin:0 auto""></div><a name=""lower""></a>

                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" width=""100%"">
                            <tbody>
                                <tr>
                                    <td valign=""top"">
                                        <div class=""pb16"">
                                            <div class=""di-t w100 mt12"">
                                                <div class=""game-detail-header-stats di-tc va-t "">
                                                    <div class=""stats-block po-r clearfix"">
                                                        <div class=""fl-l score"" data-title=""ocena"">
                                                            <div class=""score-label score-7"">");
#nullable restore
#line 28 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                        Write(Model.GameGameList.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                        </div>
                                                        <div class=""di-ib ml12 pl20 pt8"">
                                                            <span class=""numbers ranked"">Ranking<strong>#");
#nullable restore
#line 31 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                                    Write(Model.GameGameList.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                                                            <span class=\"numbers popularity\">Popularność<strong>#");
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                                            Write(Model.GameGameList.Popularity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""pb24"">
                                        <div class=""underlined_h2"">Opis</div>
");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                         if (String.IsNullOrEmpty(Model.GameGameList.Game.Description))
                                        {
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Obecnie nie ma opisu dla tej gry</p>");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                    }
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                          Write(Html.Raw(Model.GameGameList.Game.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td class=\"pb24\">\r\n\r\n");
#nullable restore
#line 57 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                         if (Model.GameGameList.Game.Series != null)
                                        {
                                            if (Model.GameGameList.Game.Series.Games.Count() > 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"underlined_h2\">Gry z serii ");
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                  Write(Model.GameGameList.Game.Series.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <table");
            BeginWriteAttribute("class", " class=\"", 3579, "\"", 3587, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""border-spacing:0px;"">
                                                    <tbody>
                                                        <tr>
                                                            <td width=""100%"" style="" display: flex; flex-direction: column;""");
            BeginWriteAttribute("class", " class=\"", 3866, "\"", 3874, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 66 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                  
                                                                    foreach (var game in Model.GameGameList.Game.Series.Games)
                                                                    {
                                                                        if (game.Id != Model.GameGameList.Game.Id)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <a");
            BeginWriteAttribute("href", " href=\"", 4414, "\"", 4436, 2);
            WriteAttributeValue("", 4421, "/games/", 4421, 7, true);
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 4428, game.Id, 4428, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                                 Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                        }

                                                                    }
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                                <br />
");
#nullable restore
#line 81 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div>\r\n                                            <span class=\"floatRightHeader\">\r\n");
#nullable restore
#line 85 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                  
                                                    if (Model.GameGameList.Game.Reviews?.Any() == true)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"display:flex;\">\r\n                                                            <a style=\"float:right; margin-right:5px; text-decoration:none; font-weight:normal;\"");
            BeginWriteAttribute("href", " href=\"", 5574, "\"", 5626, 3);
            WriteAttributeValue("", 5581, "/games/", 5581, 7, true);
#nullable restore
#line 88 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 5588, Model.GameGameList.Game.Id, 5588, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5615, "/userreview", 5615, 11, true);
            EndWriteAttribute();
            WriteLiteral(">Twoja recenzja </a>\r\n                                                            <a style=\"float:right; margin-right:5px; text-decoration:none; font-weight:normal;\"");
            BeginWriteAttribute("href", " href=\"", 5792, "\"", 5841, 2);
            WriteAttributeValue("", 5799, "/games/reviews/", 5799, 15, true);
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 5814, Model.GameGameList.Game.Id, 5814, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Więcej recenzji</a>\r\n                                                        </span>\r\n");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a style=\"float:right; margin-right:5px; text-decoration:none; font-weight:normal;\"");
            BeginWriteAttribute("href", " href=\"", 6238, "\"", 6290, 3);
            WriteAttributeValue("", 6245, "/games/", 6245, 7, true);
#nullable restore
#line 95 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 6252, Model.GameGameList.Game.Id, 6252, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6279, "/userreview", 6279, 11, true);
            EndWriteAttribute();
            WriteLiteral(">Twoja recenzja </a>\r\n");
#nullable restore
#line 96 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </span>\r\n                                            <div class=\"underlined_h2\">Recenzje</div>\r\n                                        </div>\r\n");
#nullable restore
#line 101 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                         if (Model.ReviewPlaytimes.Count() == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Obecnie nie ma recenzji dla tej gry</p>");
#nullable restore
#line 102 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                   }
                                        else
                                        {
                                            foreach (var item in Model.ReviewPlaytimes)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94696399810d23d20396a565805e6fda8d85e1e220284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 108 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

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
            WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"


                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                           if (Model.RelevantArticles.Count() > 0)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <br>\r\n                                                <div class=\"underlined_h2\">Powiązane artykuły</div>\r\n");
#nullable restore
#line 118 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"

                                                foreach (var article in Model.RelevantArticles)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"clearfix\">\r\n                                                        <div class=\"picSurround fl-l mr8 ml3 mt4\" style=\"padding-top:10px;\">\r\n");
#nullable restore
#line 123 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                             if (article.Image != null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <img style=\"max-width: 100px; max-height: 100px;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 8140, "\"", 8178, 2);
            WriteAttributeValue("", 8146, "/images/", 8146, 8, true);
#nullable restore
#line 125 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 8154, article.Image.ImagePath, 8154, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 126 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </div>\r\n                                                        <p class=\"spaceit\">\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 8448, "\"", 8476, 2);
            WriteAttributeValue("", 8455, "/articles/", 8455, 10, true);
#nullable restore
#line 129 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 8465, article.Id, 8465, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                <strong>");
#nullable restore
#line 130 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                   Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                                                            </a>
                                                        </p>
                                                        <div class=""clearfix"" style=""overflow:hidden;"">
                                                            <p>
                                                                ");
#nullable restore
#line 135 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                           Write(article.Preview);

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 8957, "\"", 8985, 2);
            WriteAttributeValue("", 8964, "/articles/", 8964, 10, true);
#nullable restore
#line 135 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 8974, article.Id, 8974, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">więcej</a>\r\n                                                            </p>\r\n                                                        </div>\r\n                                                        <p class=\"lightLink spaceit\">");
#nullable restore
#line 138 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                Write(article.PublishedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" przez <a");
            BeginWriteAttribute("href", " href=\"", 9265, "\"", 9301, 2);
            WriteAttributeValue("", 9272, "/users/", 9272, 7, true);
#nullable restore
#line 138 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
WriteAttributeValue("", 9279, article.Author.UserId, 9279, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 138 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                                                                                                         Write(article.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 138 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                                                                                                                                                                   Write(article.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                                    </div>\r\n                                                    <div class=\"borderClass\"></div>\r\n                                                    <br>\r\n");
#nullable restore
#line 142 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                                }


                                            }


                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 150 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                         if (Model.RecommendedGames?.Any() ?? false)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"underlined_h2\">Rekomendowane</div>\r\n");
#nullable restore
#line 153 "D:\PRO_Core\PRO\PRO\Views\Games\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>

                </td>
            </tr>
        </tbody>
    </table>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.GameDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
