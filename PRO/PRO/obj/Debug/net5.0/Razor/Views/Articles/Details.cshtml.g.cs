#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a575b548885b53d5221ceb3d936f4aff5406b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Details), @"mvc.1.0.view", @"/Views/Articles/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a575b548885b53d5221ceb3d936f4aff5406b7b", @"/Views/Articles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Articles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.ArticleDetailsViewModel>
    #nullable disable
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
#line 2 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"maingrid-container\">\r\n    <div class=\"news\">\r\n        <div class=\"article\">\r\n            <h1 class=\"list-title box-shadow\" style=\"margin-bottom:20px;\">");
#nullable restore
#line 10 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                                                                     Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            <div class=""news-container box-shadow"">

                <div>
                    <div class=""news-info-block clearfix mt16 mb20"">
                        <div class=""sns-unit fl-r mr8""><div class=""js-sns-icon-container icon-block mt0""></div></div>
                        <div class=""information"">
                            <div class=""author"">Autor <a");
            BeginWriteAttribute("href", " href=\"", 702, "\"", 744, 2);
            WriteAttributeValue("", 709, "/users/", 709, 7, true);
#nullable restore
#line 17 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
WriteAttributeValue("", 716, Model.Article.Author.UserId, 716, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                                                                                               Write(Model.Article.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                                                                                                                               Write(Model.Article.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br>");
#nullable restore
#line 17 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                                                                                                                                                                     Write(Model.Article.PublishedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"content\">\r\n                        <div class=\"article-image\">\r\n");
#nullable restore
#line 24 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                             if (Model.Article.Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img style=\"max-width: 100%; max-height: 100%; padding-bottom:10px;\" class=\"img\"");
            BeginWriteAttribute("src", " src=\"", 1238, "\"", 1282, 2);
            WriteAttributeValue("", 1244, "/images/", 1244, 8, true);
#nullable restore
#line 26 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
WriteAttributeValue("", 1252, Model.Article.Image.ImagePath, 1252, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 27 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n\r\n                        <div class=\"article-text m-3\">");
#nullable restore
#line 31 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                                                 Write(Html.Raw(Model.Article.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                    </div>\r\n                    <div class=\"m-3\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1541, "\"", 1573, 1);
#nullable restore
#line 34 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
WriteAttributeValue("", 1548, Model.Article.SourceLink, 1548, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" rel=\"nofollow noopener noreferrer\">Źródło</a>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <div class=\"m-3\">\r\n                    <div class=\"details\">\r\n                        <h2");
            BeginWriteAttribute("class", " class=\"", 1819, "\"", 1827, 0);
            EndWriteAttribute();
            WriteLiteral(">Powiązana gra: </h2><a");
            BeginWriteAttribute("href", " href=\"", 1851, "\"", 1886, 2);
            WriteAttributeValue("", 1858, "/games/", 1858, 7, true);
#nullable restore
#line 40 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
WriteAttributeValue("", 1865, Model.Article.GameId, 1865, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tag tag-color4\">");
#nullable restore
#line 40 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                                                                                                                  Write(Model.Article.Game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"details\">\r\n                        <h2");
            BeginWriteAttribute("class", " class=\"", 2040, "\"", 2048, 0);
            EndWriteAttribute();
            WriteLiteral(">Tagi: </h2>\r\n");
#nullable restore
#line 44 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                          
                            foreach (var tag in Model.Article.Game.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2230, "\"", 2284, 2);
            WriteAttributeValue("", 2237, "/games/Filter?currentFilter=tag&value=", 2237, 38, true);
#nullable restore
#line 47 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
WriteAttributeValue("", 2275, tag.Name, 2275, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tag tag-color4\">");
#nullable restore
#line 47 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                                                                                                            Write(tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 48 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <br />\r\n            </div>\r\n        </div>\r\n        <br />\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a575b548885b53d5221ceb3d936f4aff5406b7b11439", async() => {
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
#line 61 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a575b548885b53d5221ceb3d936f4aff5406b7b13322", async() => {
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
#line 63 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.RecentGames;

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a575b548885b53d5221ceb3d936f4aff5406b7b15202", async() => {
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
#line 65 "E:\Repo_PRO\PRO\PRO\Views\Articles\Details.cshtml"
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
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.ArticleDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
