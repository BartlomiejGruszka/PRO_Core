#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8de41f0fdf04202c371978c8224b64fcbea03b6f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de41f0fdf04202c371978c8224b64fcbea03b6f", @"/Views/Articles/Search.cshtml")]
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
            WriteLiteral("\r\n    <ul class=\"nav nav-tabs\" id=\"myTab\">\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 246, "\"", 307, 2);
            WriteAttributeValue("", 254, "nav-link", 254, 8, true);
#nullable restore
#line 9 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 262, ViewBag.platform == "all" ? "active" : "", 263, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?platform=all\">Wszystkie</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 414, "\"", 474, 2);
            WriteAttributeValue("", 422, "nav-link", 422, 8, true);
#nullable restore
#line 12 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 430, ViewBag.platform == "PC" ? "active" : "", 431, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?platform=PC\">PC</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 573, "\"", 649, 2);
            WriteAttributeValue("", 581, "nav-link", 581, 8, true);
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 589, ViewBag.platform.Contains("Playstation") ? "active" : "", 590, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?platform=Playstation\">Playstation</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 766, "\"", 835, 2);
            WriteAttributeValue("", 774, "nav-link", 774, 8, true);
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 782, ViewBag.platform.Contains("Xbox") ? "active" : "", 783, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?platform=Xbox\">Xbox</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a");
            BeginWriteAttribute("class", " class=\"", 938, "\"", 1002, 2);
            WriteAttributeValue("", 946, "nav-link", 946, 8, true);
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 954, ViewBag.platform == "Switch" ? "active" : "", 955, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?platform=Switch\">Switch</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n");
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
               bool test = (ViewBag.platform != "all" &&
                             ViewBag.platform != "PC" &&
                             !ViewBag.platform.Contains("Playstation") &&
                             !ViewBag.platform.Contains("Xbox") &&
                             ViewBag.platform != "Switch" &&
                             ViewBag.platform != "none") || ViewBag.platform == "other";
                var elementclass = test ? "active" : "";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("class", " class=\"", 1593, "\"", 1623, 2);
            WriteAttributeValue("", 1601, "nav-link", 1601, 8, true);
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue(" ", 1609, elementclass, 1610, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/articles?platform=other\">Inne</a>\r\n\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 1753, "\"", 1791, 2);
            WriteAttributeValue("", 1760, "/articles/search/", 1760, 17, true);
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 1777, ViewBag.Query, 1777, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Wyszukiwanie</a>\r\n        </li>\r\n\r\n    </ul>\r\n\r\n    <div id=\"myTabContent\" class=\"tab-content\">\r\n        <div class=\"tab-pane fade active show\" id=\"all\">\r\n            <div class=\"list-group\">\r\n");
#nullable restore
#line 44 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                  
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"news-list mt16 mr8\">\r\n                            <div class=\"news-unit\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2223, "\"", 2248, 2);
            WriteAttributeValue("", 2230, "/articles/", 2230, 10, true);
#nullable restore
#line 49 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 2240, item.Id, 2240, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-link\">\r\n                                    <img style=\"max-height:300px;max-width:200px;\" class=\"img\" alt=\"myimage\"");
            BeginWriteAttribute("src", " src=\"", 2379, "\"", 2414, 2);
            WriteAttributeValue("", 2385, "/images/", 2385, 8, true);
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 2393, item.Image.ImagePath, 2393, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a><div class=\"news-unit-right\">\r\n                                    <p class=\"title\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2582, "\"", 2607, 2);
            WriteAttributeValue("", 2589, "/articles/", 2589, 10, true);
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 2599, item.Id, 2599, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </p>\r\n                                    <div class=\"text\">\r\n                                        ");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                   Write(item.Preview);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"information\">\r\n                                        <p class=\"info di-ib\">\r\n                                            ");
#nullable restore
#line 60 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                       Write(item.PublishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <text>by</text> <a href=\"#\">");
#nullable restore
#line 60 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                                       Write(item.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> <a");
            BeginWriteAttribute("href", " href=\"", 3071, "\"", 3121, 2);
            WriteAttributeValue("", 3078, "/articles?platform=", 3078, 19, true);
#nullable restore
#line 60 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
WriteAttributeValue("", 3097, item.Game.Platform.Name, 3097, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item\">");
#nullable restore
#line 60 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
                                                                                                                                                                                         Write(item.Game.Platform.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 66 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"

                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div>\r\n");
#nullable restore
#line 75 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
          Model.Pagination.Route = "articles/search/" + ViewBag.Query+"?";

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8de41f0fdf04202c371978c8224b64fcbea03b6f13140", async() => {
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
#line 76 "D:\PRO_Core\PRO\PRO\Views\Articles\Search.cshtml"
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
