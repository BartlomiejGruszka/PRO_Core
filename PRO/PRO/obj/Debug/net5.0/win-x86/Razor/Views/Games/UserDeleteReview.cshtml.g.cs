#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8166a3fbe8400612f54b80b40f9ab5d62d568b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_UserDeleteReview), @"mvc.1.0.view", @"/Views/Games/UserDeleteReview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8166a3fbe8400612f54b80b40f9ab5d62d568b12", @"/Views/Games/UserDeleteReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_UserDeleteReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.GameDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_GameTitleBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_GameInfoBar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
  
    ViewBag.Title = "Reviews";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8166a3fbe8400612f54b80b40f9ab5d62d568b123876", async() => {
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
#line 6 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.GameInfo.Game;

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8166a3fbe8400612f54b80b40f9ab5d62d568b125898", async() => {
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
#line 12 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.GameInfo;

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
                                    <td class=""pb24"">

                                        <div class=""underlined_h2"">Usuń recenzję</div>
                                        <div class=""col-md-offset-2 col-md-10"">





                                            <div>
                                                <h2>Czy na pewno chcesz usunąć recenzję gry <b>");
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
                                                                                          Write(Model.GameInfo.Game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>?</h2>\r\n\r\n                                                <br />\r\n                                            </div>\r\n");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
                                             using (Html.BeginForm("UserDelete", "Reviews", new { id = Model.ReviewPlaytimes[0].Review.Id, gameid = Model.GameInfo.Game.Id }, FormMethod.Post))
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
                                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"form-actions no-color\">\r\n                                                    <input type=\"submit\" value=\"Usuń\" class=\"btn btn-primary\" />\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 1907, "\"", 1988, 4);
            WriteAttributeValue("", 1914, "/games/", 1914, 7, true);
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
WriteAttributeValue("", 1921, Model.GameInfo.Game.Id, 1921, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1944, "/reviews/", 1944, 9, true);
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
WriteAttributeValue("", 1953, Model.ReviewPlaytimes[0].Review.Id, 1953, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"padding-left:10px;\" class=\"btn btn-secondary\">Powrót</a>\r\n                                                </div>\r\n");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Games\UserDeleteReview.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                        </div>


                                    </td>
                                </tr>

                            </tbody>

                        </table>
                    </div>
                    <div>
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