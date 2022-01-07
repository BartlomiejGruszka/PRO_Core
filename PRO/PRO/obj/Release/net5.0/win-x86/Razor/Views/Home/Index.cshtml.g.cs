#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9d41b43bbd3c3079fe1a8560bb2035eac52920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
using PRO.Domain.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9d41b43bbd3c3079fe1a8560bb2035eac52920", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_BestRatedGames.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_ClosestReleaseGames.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_NewReviews.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
  string StripHTML(string input, int length)
    {
        if (!string.IsNullOrEmpty(input))
        {
            input = Regex.Replace(input, "<.*?>", String.Empty);
            input = Regex.Replace(input, "&nbsp;", " ");
            input = input.Truncate(length);
            return input;
        }
        else
        {
            return "";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"maingrid-container\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 585, "\"", 593, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"list-group box-shadow\">\r\n            <h2 class=\"list-title box-shadow\">Bieżące informacje</h2>\r\n");
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
              
                var articles = Model.RecentArticles.ToList().Take(3);
                foreach (var article in articles)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 894, "\"", 922, 2);
            WriteAttributeValue("", 901, "/articles/", 901, 10, true);
#nullable restore
#line 35 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 911, article.Id, 911, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action flex-column align-items-start \" id=\"home-article-cards\">\r\n                        <div>\r\n");
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                             if (article.Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<img style=\"max-width: 150px;max-height: 100%;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 1212, "\"", 1250, 2);
            WriteAttributeValue("", 1218, "/images/", 1218, 8, true);
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 1226, article.Image.ImagePath, 1226, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 39 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div>\r\n                            <div class=\"d-flex w-100 justify-content-between\">\r\n                                <h5 class=\"mb-1\">");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                            Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <p class=\"mb-1\">");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                       Write(article.Preview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                                 Write(article.PublishedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" przez ");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                                                                                  Write(article.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                                                                                                            Write(article.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <br />\r\n        <div>\r\n\r\n            <h2 class=\"list-title box-shadow\">Ostatnie premiery</h2>\r\n            <div class=\"leftinnergrid-container box-shadow\">\r\n\r\n");
#nullable restore
#line 58 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                  
                    var games = Model.RecentGames.ToList().Take(4);

                    foreach (var game in games)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card recentlyReleasedGames\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2297, "\"", 2319, 2);
            WriteAttributeValue("", 2304, "/games/", 2304, 7, true);
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 2311, game.Id, 2311, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none; color:black; display:block;width: 100%; \">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 2430, "\"", 2438, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div style=\" text-align: center;\">\r\n");
#nullable restore
#line 67 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                         if (game.Image != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img style=\"max-width: 100%; max-height: 100%;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 2734, "\"", 2769, 2);
            WriteAttributeValue("", 2740, "/images/", 2740, 8, true);
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 2748, game.Image.ImagePath, 2748, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 70 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"card-body\">\r\n\r\n                                        <p class=\"card-ellipsis\">");
#nullable restore
#line 74 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                                            Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </a>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 81 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"

                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"list-group box-shadow\">\r\n            <h2 class=\"list-title box-shadow\">Najpopularniejsze</h2>\r\n");
#nullable restore
#line 89 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
              
                var popularGames = Model.MostPopularGames;

                foreach (var item in popularGames)
                {
                    var game = item.Item1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3570, "\"", 3592, 2);
            WriteAttributeValue("", 3577, "/games/", 3577, 7, true);
#nullable restore
#line 95 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 3584, game.Id, 3584, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action flex-column align-items-start \" id=\"home-article-cards\">\r\n                        <div>\r\n");
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                             if (game.Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img style=\"max-width: 100px;max-height: 100%;align-self: flex-start;flex-direction: row;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 3956, "\"", 3991, 2);
            WriteAttributeValue("", 3962, "/images/", 3962, 8, true);
#nullable restore
#line 99 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 3970, game.Image.ImagePath, 3970, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 100 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div>\r\n                            <div class=\"d-flex w-100 justify-content-between\">\r\n                                <h5 class=\"mb-1\">");
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                            Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <p class=\"mb-1\">\r\n");
#nullable restore
#line 107 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                                   var content = StripHTML(@game.Description, 300);
                                    if (content.Length == 300)
                                    {
                                        content = content + "...";
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 113 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                           Write(Html.Raw(content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 118 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <br />\r\n    </div>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec9d41b43bbd3c3079fe1a8560bb2035eac5292015859", async() => {
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
#line 125 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.BestRatedGames;

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
            WriteLiteral("\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec9d41b43bbd3c3079fe1a8560bb2035eac5292017737", async() => {
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
#line 127 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ComingGames;

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
            WriteLiteral("\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec9d41b43bbd3c3079fe1a8560bb2035eac5292019612", async() => {
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
#line 129 "D:\PRO_Core\PRO\PRO\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.RecentReviews;

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
            WriteLiteral("\r\n        <br />\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
