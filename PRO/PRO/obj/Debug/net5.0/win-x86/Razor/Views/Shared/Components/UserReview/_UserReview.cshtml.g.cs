#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f12377f64e737d55d7fde10d3a0bca7c60fb7e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserReview__UserReview), @"mvc.1.0.view", @"/Views/Shared/Components/UserReview/_UserReview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f12377f64e737d55d7fde10d3a0bca7c60fb7e4", @"/Views/Shared/Components/UserReview/_UserReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserReview__UserReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.Review>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
 using (Html.BeginForm("UserReview", "Reviews"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <hr />\r\n    ");
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       var revid = 0;
        var revdate = ViewBag.ReviewDate;
        if (ViewBag.ReviewId != null) revid = ViewBag.ReviewId;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input data-val=\"true\" data-val-required=\"The Int32 field is required.\" id=\"ReviewDate\" name=\"ReviewDate\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 497, "\"", 524, 1);
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
WriteAttributeValue("", 505, ViewBag.ReviewDate, 505, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input data-val=\"true\" data-val-required=\"The Int32 field is required.\" id=\"AddedDate\" name=\"GameId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 646, "\"", 669, 1);
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
WriteAttributeValue("", 654, ViewBag.GameId, 654, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input data-val=\"true\" data-val-required=\"The Int32 field is required.\" id=\"UserId\" name=\"UserId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 788, "\"", 811, 1);
#nullable restore
#line 17 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
WriteAttributeValue("", 796, ViewBag.UserId, 796, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input data-val=\"true\" data-val-required=\"The Int32 field is required.\" id=\"Id\" name=\"Id\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 922, "\"", 936, 1);
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
WriteAttributeValue("", 930, revid, 930, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
   Write(Html.LabelFor(model => model.Content, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.TextAreaFor(model => model.Content, new { @id = "mytextarea", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.ValidationMessageFor(model => model.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
   Write(Html.LabelFor(model => model.GraphicsScore, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.EditorFor(model => model.GraphicsScore, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.ValidationMessageFor(model => model.GraphicsScore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 35 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
   Write(Html.LabelFor(model => model.StoryScore, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.EditorFor(model => model.StoryScore, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.ValidationMessageFor(model => model.StoryScore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
   Write(Html.LabelFor(model => model.MusicScore, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.EditorFor(model => model.MusicScore, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.ValidationMessageFor(model => model.MusicScore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 51 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
   Write(Html.LabelFor(model => model.GameplayScore, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.EditorFor(model => model.GameplayScore, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
       Write(Html.ValidationMessageFor(model => model.GameplayScore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Zapisz\" class=\"btn btn-primary\" />\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3213, "\"", 3242, 2);
            WriteAttributeValue("", 3220, "/games/", 3220, 7, true);
#nullable restore
#line 61 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
WriteAttributeValue("", 3227, ViewBag.GameId, 3227, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Powrót</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\UserReview\_UserReview.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f12377f64e737d55d7fde10d3a0bca7c60fb7e412627", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591
