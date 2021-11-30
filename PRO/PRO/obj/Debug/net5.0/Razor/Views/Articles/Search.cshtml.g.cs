#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f118d6858c774c626d6b4c07e0ee91ad41b4a837"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f118d6858c774c626d6b4c07e0ee91ad41b4a837", @"/Views/Articles/Search.cshtml")]
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
#nullable restore
#line 6 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
   string currentFilter = Model.Pagination.CurrentFilter;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"box-shadow window-background\">\r\n    <ul class=\"nav nav-tabs\" id=\"myTab\">\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 332, "\"", 390, 2);
            WriteAttributeValue("", 340, "nav-link", 340, 8, true);
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 348, currentFilter == "all" ? "active" : "", 349, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?currentFilter=all\">Wszystkie</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 502, "\"", 559, 2);
            WriteAttributeValue("", 510, "nav-link", 510, 8, true);
#nullable restore
#line 13 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 518, currentFilter == "PC" ? "active" : "", 519, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?currentFilter=PC\">PC</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 663, "\"", 736, 2);
            WriteAttributeValue("", 671, "nav-link", 671, 8, true);
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 679, currentFilter.Contains("Playstation") ? "active" : "", 680, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?currentFilter=Playstation\">Playstation</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 858, "\"", 924, 2);
            WriteAttributeValue("", 866, "nav-link", 866, 8, true);
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 874, currentFilter.Contains("Xbox") ? "active" : "", 875, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?currentFilter=Xbox\">Xbox</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 1032, "\"", 1093, 2);
            WriteAttributeValue("", 1040, "nav-link", 1040, 8, true);
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 1048, currentFilter == "Switch" ? "active" : "", 1049, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?currentFilter=Switch\">Switch</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 1229, "\"", 1267, 2);
            WriteAttributeValue("", 1236, "/articles/search/", 1236, 17, true);
#nullable restore
#line 25 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1253, currentFilter, 1253, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Wyszukiwanie</a>\r\n        </li>\r\n\r\n    </ul>\r\n\r\n    <div id=\"myTabContent\" class=\"tab-content\">\r\n        <div class=\"tab-pane fade active show\" id=\"all\">\r\n            <div class=\"list-group\">\r\n");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                  
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"news-list mt16 mr8\">\r\n                            <div class=\"news-unit\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1699, "\"", 1724, 2);
            WriteAttributeValue("", 1706, "/articles/", 1706, 10, true);
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1716, item.Id, 1716, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-link\">\r\n                                    <img style=\"max-height:300px;max-width:200px;\" class=\"img\" alt=\"myimage\"");
            BeginWriteAttribute("src", " src=\"", 1855, "\"", 1890, 2);
            WriteAttributeValue("", 1861, "/images/", 1861, 8, true);
#nullable restore
#line 39 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1869, item.Image.ImagePath, 1869, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a><div class=\"news-unit-right\">\r\n                                    <p class=\"title\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2058, "\"", 2083, 2);
            WriteAttributeValue("", 2065, "/articles/", 2065, 10, true);
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 2075, item.Id, 2075, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </p>\r\n                                    <div class=\"text\">\r\n                                        ");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                   Write(item.Preview);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"information\">\r\n                                        <p class=\"info di-ib\">\r\n                                            ");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                       Write(item.PublishedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <text>przez</text> <a href=\"#\">");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                                                              Write(item.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> dla <a");
            BeginWriteAttribute("href", " href=\"", 2574, "\"", 2624, 2);
            WriteAttributeValue("", 2581, "/articles?platform=", 2581, 19, true);
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 2600, item.Game.Platform.Name, 2600, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item\">");
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                                                                                                                                                                    Write(item.Game.Platform.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f118d6858c774c626d6b4c07e0ee91ad41b4a83712042", async() => {
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
#line 64 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
