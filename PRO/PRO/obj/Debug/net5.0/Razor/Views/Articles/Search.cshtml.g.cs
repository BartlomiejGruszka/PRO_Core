#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c656395f2bcfcdcd1b0a4fb64a5ff591281efa70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Search), @"mvc.1.0.view", @"/Views/Articles/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c656395f2bcfcdcd1b0a4fb64a5ff591281efa70", @"/Views/Articles/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.PaginatedList<PRO.Entities.Article>>
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
#line 2 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
      
        ViewBag.Title = "Index";
        Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"nav nav-tabs\" id=\"myTab\">\r\n    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 234, "\"", 315, 2);
            WriteAttributeValue("", 242, "nav-link", 242, 8, true);
#nullable restore
#line 9 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 250, ViewData["CurrentFilter"].ToString() == "all" ? "active" : "", 251, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?query=all\">Wszystkie</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 407, "\"", 487, 2);
            WriteAttributeValue("", 415, "nav-link", 415, 8, true);
#nullable restore
#line 12 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 423, ViewData["CurrentFilter"].ToString() == "PC" ? "active" : "", 424, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?query=PC\">PC</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 571, "\"", 667, 2);
            WriteAttributeValue("", 579, "nav-link", 579, 8, true);
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 587, ViewData["CurrentFilter"].ToString().Contains("Playstation") ? "active" : "", 588, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?query=Playstation\">Playstation</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 769, "\"", 858, 2);
            WriteAttributeValue("", 777, "nav-link", 777, 8, true);
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 785, ViewData["CurrentFilter"].ToString().Contains("Xbox") ? "active" : "", 786, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?query=Xbox\">Xbox</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 946, "\"", 1030, 2);
            WriteAttributeValue("", 954, "nav-link", 954, 8, true);
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 962, ViewData["CurrentFilter"].ToString() == "Switch" ? "active" : "", 963, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?query=Switch\">Switch</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1196, 2);
            WriteAttributeValue("", 1153, "/articles/search/", 1153, 17, true);
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1170, ViewData["CurrentFilter"], 1170, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Wyszukiwanie</a>\r\n    </li>\r\n\r\n</ul>\r\n\r\n    <div id=\"myTabContent\" class=\"tab-content\">\r\n        <div class=\"tab-pane fade active show\" id=\"all\">\r\n            <div class=\"list-group\">\r\n");
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                  
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"news-list mt16 mr8\">\r\n                            <div class=\"news-unit\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1620, "\"", 1645, 2);
            WriteAttributeValue("", 1627, "/articles/", 1627, 10, true);
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1637, item.Id, 1637, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-link\">\r\n                                    <img style=\"max-height:300px;max-width:200px;\" class=\"img\" alt=\"myimage\"");
            BeginWriteAttribute("src", " src=\"", 1776, "\"", 1811, 2);
            WriteAttributeValue("", 1782, "/images/", 1782, 8, true);
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1790, item.Image.ImagePath, 1790, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a><div class=\"news-unit-right\">\r\n                                    <p class=\"title\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1979, "\"", 2004, 2);
            WriteAttributeValue("", 1986, "/articles/", 1986, 10, true);
#nullable restore
#line 41 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1996, item.Id, 1996, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </p>\r\n                                    <div class=\"text\">\r\n                                        ");
#nullable restore
#line 44 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                   Write(item.Preview);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"information\">\r\n                                        <p class=\"info di-ib\">\r\n                                            ");
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                       Write(item.PublishedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <text>przez</text> <a href=\"#\">");
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                                                              Write(item.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> dla <a");
            BeginWriteAttribute("href", " href=\"", 2495, "\"", 2545, 2);
            WriteAttributeValue("", 2502, "/articles?platform=", 2502, 19, true);
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 2521, item.Game.Platform.Name, 2521, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item\">");
#nullable restore
#line 48 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                                                                                                                                                                    Write(item.Game.Platform.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c656395f2bcfcdcd1b0a4fb64a5ff591281efa7011829", async() => {
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
#line 63 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Pagination;

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
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.PaginatedList<PRO.Entities.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
