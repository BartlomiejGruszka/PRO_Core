#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73b511987b636316218e7e66f5461f1988bc22aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Reviews), @"mvc.1.0.view", @"/Views/Users/Reviews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73b511987b636316218e7e66f5461f1988bc22aa", @"/Views/Users/Reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Reviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Users/_UserLeftSide.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_SingleReview.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
  
    ViewBag.Title = "Profil użytkownika";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1 class=\"main_h1 edit-info\">\r\n        <span class=\"h1-title\">\r\n            <span>\r\n                ");
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
           Write(Model.EditUser.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n\r\n        </span>\r\n    </h1>\r\n</div>\r\n<div id=\"content\" class=\"userprofilecontent\">\r\n");
#nullable restore
#line 17 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
     if (Model.EditUser.AppUser.IsPublic)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73b511987b636316218e7e66f5461f1988bc22aa4542", async() => {
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
#line 19 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.EditUser.AppUser;

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
            WriteLiteral(@"        <div valign=""top"" style=""padding-left: 5px;"">
            <div class=""js-scrollfix-bottom-rel"">
                <div style="" margin:0 auto""></div><a name=""lower""></a>

                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
                    <tbody>
                        <tr>
                            <td valign=""top"" style=""padding-left: 5px;"">
                                <div class=""js-scrollfix-bottom-rel"">
                                    <div style="" margin:0 auto""></div><a name=""lower""></a>

                                    <table border=""0"" cellspacing=""0"" cellpadding=""0"" width=""100%"">
                                        <tbody>
                                            <tr>
                                                <td class=""pb24"">

                                                    <div class=""underlined_h2"">
                                                        <text");
            BeginWriteAttribute("class", " class=\"", 1516, "\"", 1524, 0);
            EndWriteAttribute();
            WriteLiteral(">Wszystkie recenzje</text>\r\n                                                        <a style=\"float:right; text-decoration:none; font-weight:normal;\"");
            BeginWriteAttribute("href", " href=\"", 1674, "\"", 1714, 2);
            WriteAttributeValue("", 1681, "/users/", 1681, 7, true);
#nullable restore
#line 40 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 1688, Model.EditUser.AppUser.Id, 1688, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Powrót</a>\r\n                                                    </div>\r\n");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                                      
                                                        var start = ViewBag.Pagination.pageIteratorStart;
                                                        var end = ViewBag.Pagination.pageIteratorEnd;
                                                        var reviewGametime = Model.ReviewsPlaytimes.ToArray();
                                                        for (var i = start; i <= end; i++)
                                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73b511987b636316218e7e66f5461f1988bc22aa8975", async() => {
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
#line 49 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = reviewGametime[i];

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
            WriteLiteral("                                                            <div class=\"underlined_h2\"></div>\r\n");
#nullable restore
#line 52 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
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
                                <div>
                                    <ul class=""pagination"">
");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                          
                                            var first = ViewBag.Pagination.firstPage;
                                            var current = ViewBag.Pagination.currentPage;
                                            var previous = ViewBag.Pagination.previousPage;
                                            var items = ViewBag.Pagination.itemsPerPage;
                                            var next = ViewBag.Pagination.nextPage;
                                            var last = ViewBag.Pagination.lastPage;
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                          
                                            if (@current >= 3)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\">\r\n                                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3947, "\"", 4020, 6);
            WriteAttributeValue("", 3954, "/users/", 3954, 7, true);
#nullable restore
#line 80 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 3961, Model.EditUser.AppUser.Id, 3961, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3987, "/reviews?page=", 3987, 14, true);
#nullable restore
#line 80 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4001, first, 4001, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4007, "&items=", 4007, 7, true);
#nullable restore
#line 80 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4014, items, 4014, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">«</a>\r\n                                                </li>\r\n");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                            }
                                            if (@current >= 2 && @previous != @current)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\">\r\n                                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4411, "\"", 4487, 6);
            WriteAttributeValue("", 4418, "/users/", 4418, 7, true);
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4425, Model.EditUser.AppUser.Id, 4425, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4451, "/reviews?page=", 4451, 14, true);
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4465, previous, 4465, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4474, "&items=", 4474, 7, true);
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4481, items, 4481, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                                                                                                                                 Write(previous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 88 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item active\">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4751, "\"", 4826, 6);
            WriteAttributeValue("", 4758, "/users/", 4758, 7, true);
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4765, Model.EditUser.AppUser.Id, 4765, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4791, "/reviews?page=", 4791, 14, true);
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4805, current, 4805, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4813, "&items=", 4813, 7, true);
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 4820, items, 4820, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                                                                                                                            Write(current);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 93 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"

                                            if (@last > @current)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\">\r\n                                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5153, "\"", 5225, 6);
            WriteAttributeValue("", 5160, "/users/", 5160, 7, true);
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 5167, Model.EditUser.AppUser.Id, 5167, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5193, "/reviews?page=", 5193, 14, true);
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 5207, next, 5207, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5212, "&items=", 5212, 7, true);
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 5219, items, 5219, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                                                                                                                             Write(next);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </li>\r\n");
#nullable restore
#line 99 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                            }

                                            if (@last > @current + 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\">\r\n                                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5604, "\"", 5676, 6);
            WriteAttributeValue("", 5611, "/users/", 5611, 7, true);
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 5618, Model.EditUser.AppUser.Id, 5618, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5644, "/reviews?page=", 5644, 14, true);
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 5658, last, 5658, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5663, "&items=", 5663, 7, true);
#nullable restore
#line 104 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
WriteAttributeValue("", 5670, items, 5670, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&raquo;</a>\r\n                                                </li>\r\n");
#nullable restore
#line 106 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 118 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"display:flex; justify-content:center; margin-top:1rem;\">Ten profil jest prywatny</p>\r\n");
#nullable restore
#line 123 "D:\PRO_Core\PRO\PRO\Views\Users\Reviews.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
