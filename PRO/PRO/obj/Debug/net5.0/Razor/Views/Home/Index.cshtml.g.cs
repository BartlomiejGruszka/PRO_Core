#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114909b2fb31d9b073eb9cccc0a031d31373f7a3"
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
#line 1 "E:\Repo_PRO\PRO\PRO\Views\_ViewImports.cshtml"
using PRO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repo_PRO\PRO\PRO\Views\_ViewImports.cshtml"
using PRO.UI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
using PRO.Domain.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114909b2fb31d9b073eb9cccc0a031d31373f7a3", @"/Views/Home/Index.cshtml")]
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
#line 3 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
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
            WriteLiteral(">\r\n        <div class=\"list-group\">\r\n            <h2 class=\"list-title box-shadow\">Bieżące informacje</h2>\r\n");
#nullable restore
#line 30 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
              
                var articles = Model.RecentArticles.ToList().Take(3);
                foreach (var article in articles)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 883, "\"", 911, 2);
            WriteAttributeValue("", 890, "/articles/", 890, 10, true);
#nullable restore
#line 35 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 900, article.Id, 900, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action flex-column align-items-start box-shadow\" id=\"home-article-cards\">\r\n                        <div>\r\n");
#nullable restore
#line 37 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                             if (article.Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<img style=\"max-width: 150px;max-height: 100%;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 1211, "\"", 1249, 2);
            WriteAttributeValue("", 1217, "/images/", 1217, 8, true);
#nullable restore
#line 38 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 1225, article.Image.ImagePath, 1225, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 39 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div>\r\n                            <div class=\"d-flex w-100 justify-content-between\">\r\n                                <h5 class=\"mb-1\">");
#nullable restore
#line 43 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                            Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <p class=\"mb-1\">");
#nullable restore
#line 45 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                       Write(article.Preview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 46 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                                 Write(article.PublishedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" przez ");
#nullable restore
#line 46 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                                                                                  Write(article.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                                                                                                            Write(article.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 49 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <br />\r\n        <div>\r\n\r\n            <h2 class=\"list-title box-shadow\">Ostatnie premiery</h2>\r\n            <div class=\"leftinnergrid-container\">\r\n\r\n");
#nullable restore
#line 58 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                  
                    var games = Model.RecentGames.ToList().Take(4);

                    foreach (var game in games)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card recentlyReleasedGames box-shadow\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2296, "\"", 2318, 2);
            WriteAttributeValue("", 2303, "/games/", 2303, 7, true);
#nullable restore
#line 64 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 2310, game.Id, 2310, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none; color:black; display:block;width: 100%; \">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 2429, "\"", 2437, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div style=\" text-align: center;\">\r\n");
#nullable restore
#line 67 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                         if (game.Image != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img style=\"max-width: 100%; max-height: 100%;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 2733, "\"", 2768, 2);
            WriteAttributeValue("", 2739, "/images/", 2739, 8, true);
#nullable restore
#line 69 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 2747, game.Image.ImagePath, 2747, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 70 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"card-body\">\r\n\r\n                                        <p class=\"card-ellipsis\">");
#nullable restore
#line 74 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                                            Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </a>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 81 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"

                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"list-group\">\r\n            <h2 class=\"list-title box-shadow\">Najpopularniejsze</h2>\r\n");
#nullable restore
#line 89 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
              
                var popularGames = Model.MostPopularGames;

                foreach (var item in popularGames)
                {
                    var game = item.Item1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3558, "\"", 3580, 2);
            WriteAttributeValue("", 3565, "/games/", 3565, 7, true);
#nullable restore
#line 95 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 3572, game.Id, 3572, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action flex-column align-items-start box-shadow\" id=\"home-article-cards\">\r\n                        <div>\r\n");
#nullable restore
#line 97 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                             if (game.Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img style=\"max-width: 100px;max-height: 100%;align-self: flex-start;flex-direction: row;\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 3954, "\"", 3989, 2);
            WriteAttributeValue("", 3960, "/images/", 3960, 8, true);
#nullable restore
#line 99 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
WriteAttributeValue("", 3968, game.Image.ImagePath, 3968, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 100 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div>\r\n                            <div class=\"d-flex w-100 justify-content-between\">\r\n                                <h5 class=\"mb-1\">");
#nullable restore
#line 104 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                                            Write(game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <p class=\"mb-1\">\r\n");
#nullable restore
#line 107 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
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
#line 113 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                           Write(Html.Raw(content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 118 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <br />\r\n    </div>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "114909b2fb31d9b073eb9cccc0a031d31373f7a315857", async() => {
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
#line 125 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "114909b2fb31d9b073eb9cccc0a031d31373f7a317735", async() => {
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
#line 127 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "114909b2fb31d9b073eb9cccc0a031d31373f7a319610", async() => {
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
#line 129 "E:\Repo_PRO\PRO\PRO\Views\Home\Index.cshtml"
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
