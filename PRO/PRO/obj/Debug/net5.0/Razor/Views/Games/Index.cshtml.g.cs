#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3737cfd1e85bcd5865b3c032aaa994ad744bda9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Index), @"mvc.1.0.view", @"/Views/Games/Index.cshtml")]
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
#line 2 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
using PRO.Domain.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
using PRO.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3737cfd1e85bcd5865b3c032aaa994ad744bda9", @"/Views/Games/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.GameFilterViewModel>
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
#line 7 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    bool userLoggedIn = (SignInManager.IsSignedIn(User));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" class=""top-ranking-table"">
        <tbody>
            <tr class=""table-header"">
                <td class=""title"">Tytuł</td>
                <td class=""score"">Średnia ocena</td>
");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                   if (userLoggedIn)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"your-score\">Twoja ocena</td>\r\n");
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"status\">Status</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
              
                foreach(var item in Model.GamesScores)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"ranking-list\">\r\n                        <td class=\"title al va-t word-break\">\r\n                            <div class=\"gameListImageGrid\">\r\n                                <div>\r\n");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                     if (item.Game.Image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"fl-l ml12 mr8\"");
            BeginWriteAttribute("href", " href=\"", 1334, "\"", 1361, 2);
            WriteAttributeValue("", 1341, "/games/", 1341, 7, true);
#nullable restore
#line 35 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
WriteAttributeValue("", 1348, item.Game.Id, 1348, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"position: relative;\">\r\n                                            <img width=\"70\" height=\"90\" class=\" lazyloaded\" border=\"0\"");
            BeginWriteAttribute("src", " src=\"", 1495, "\"", 1535, 2);
            WriteAttributeValue("", 1501, "/images/", 1501, 8, true);
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
WriteAttributeValue("", 1509, item.Game.Image.ImagePath, 1509, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n");
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n\r\n                                <div class=\"detail\">\r\n                                    <div class=\"di-flex clearfix\">\r\n                                        <a");
            BeginWriteAttribute("class", " class=\"", 1830, "\"", 1838, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1839, "\"", 1866, 2);
            WriteAttributeValue("", 1846, "/games/", 1846, 7, true);
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
WriteAttributeValue("", 1853, item.Game.Id, 1853, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                                                           Write(item.Game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n                                    <div class=\"information di-ib mt4\" style=\"overflow:hidden; text-overflow:clip; max-width:500px; min-width:200px;\">\r\n                                        ");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                   Write(Html.Raw(item.Game.Description.Truncate(140)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...<a");
            BeginWriteAttribute("href", " href=\"", 2177, "\"", 2204, 2);
            WriteAttributeValue("", 2184, "/games/", 2184, 7, true);
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
WriteAttributeValue("", 2191, item.Game.Id, 2191, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">więcej</a>
                                    </div>
                                </div>
                            </div>
                        </td>

                        <td class=""score ac fs14"">
                            <div class=""js-top-ranking-score-col di-ib al"" style=""width: 48.7969px;"">
                                <i class=""icon-score-star mr4 on""></i>
                                <span class=""text on score-label score-9"">
");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                      
                                        if (item.Score.HasValue && !Double.IsNaN(item.Score.Value))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                       Write(Math.Round((double)item.Score.Value));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                                                                 
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            WriteLiteral("0\r\n");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n                            </div>\r\n                        </td>\r\n");
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
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
#line 76 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td class=\"status ac\">\r\n                            <i class=\"fa fa-plus-square-o mr4\"></i>");
#nullable restore
#line 79 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
                                                              Write(item.Game.Status.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"

                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
      Model.GamesScores.Pagination.Route = "games?";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3737cfd1e85bcd5865b3c032aaa994ad744bda912328", async() => {
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
#line 92 "D:\PRO_Core\PRO\PRO\Views\Games\Index.cshtml"
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
            WriteLiteral("\r\n</div>\r\n");
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
