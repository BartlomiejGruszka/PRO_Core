#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Add), @"mvc.1.0.view", @"/Views/Games/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185bb79cf53f81d47df37a4a52c8e42c58c2e5fd", @"/Views/Games/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.GameViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
  
    ViewBag.Title = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Dodaj nową grę</h2>\r\n\r\n");
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
 using (Html.BeginForm("Add", "Games"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <hr />\r\n    ");
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 20 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.EditorFor(model => model.Game.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 28 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.TextAreaFor(model => model.Game.Description, new { @id = "mytextarea", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.ReleaseDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.EditorFor(model => model.Game.ReleaseDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.ReleaseDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.IsActive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <div class=\"checkbox\">\r\n                ");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
           Write(Html.EditorFor(model => model.Game.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
           Write(Html.ValidationMessageFor(model => model.Game.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 51 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.PlatformId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker show-tick\" style=\"max-width:400px;\" id=\"Game.PlatformId\" name=\"Game.PlatformId\" data-live-search=\"true\" title=\"Wybierz platformę\">\r\n");
#nullable restore
#line 54 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Platforms)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd8980", async() => {
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 60 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.PlatformId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.StatusId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"Game.StatusId\" name=\"Game.StatusId\" data-live-search=\"true\" title=\"Wybierz status\">\r\n");
#nullable restore
#line 67 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Statuses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd11993", async() => {
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 73 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.StatusId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 77 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.GenreId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"Game.GenreId\" name=\"Game.GenreId\" data-live-search=\"true\" title=\"Wybierz gatunek\">\r\n");
#nullable restore
#line 80 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Genres)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd15001", async() => {
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 83 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 86 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.GenreId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 90 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.Series, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"Game.SeriesId\" name=\"Game.SeriesId\" data-live-search=\"true\" title=\"Wybierz serię\">\r\n");
#nullable restore
#line 93 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Series)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd18007", async() => {
#nullable restore
#line 95 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 96 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 99 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.SeriesId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 103 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.ImageTypes, "Rodzaj obrazka", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" id=\"SelectedImageTypeId\" name=\"SelectedImageTypeId\" data-live-search=\"true\" onchange=\"javascript:GetImagesByType(this.value);\" title=\"Wybierz rodzaj obrazka\">\r\n");
#nullable restore
#line 106 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.ImageTypes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd21084", async() => {
#nullable restore
#line 108 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 112 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.PublisherId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 116 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.ImageId, "Obraz", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"ImageId\" name=\"Game.ImageId\" data-live-search=\"true\" onchange=\"SetImageId()\" title=\"Wybierz obraz\">\r\n            </select>\r\n            ");
#nullable restore
#line 120 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.ImageId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 125 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.PublisherId, "Wydawca", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"Game.PublisherId\" name=\"Game.PublisherId\" data-live-search=\"true\" title=\"Wybierz wydawcę\">\r\n");
#nullable restore
#line 128 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Publishers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd25030", async() => {
#nullable restore
#line 130 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 131 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 134 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.PublisherId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 138 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.DeveloperId, "Producent", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"Game.DeveloperId\" name=\"Game.DeveloperId\" data-live-search=\"true\" title=\"Wybierz producenta\">\r\n");
#nullable restore
#line 141 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Developers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd28079", async() => {
#nullable restore
#line 143 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 144 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 147 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.DeveloperId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 151 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.Languages, "Języki", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"selectedLanguagesId\" name=\"selectedLanguagesId\" data-live-search=\"true\" multiple title=\"Wybierz języki\">\r\n");
#nullable restore
#line 154 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Languages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd31133", async() => {
#nullable restore
#line 156 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 157 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 160 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.Languages, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 164 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
   Write(Html.LabelFor(model => model.Game.Tags, "Tagi", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <select class=\"selectpicker form-control\" style=\"max-width:400px;\" id=\"selectedTagsId\" name=\"selectedTagsId\" data-live-search=\"true\" multiple title=\"Wybierz tagi\">\r\n");
#nullable restore
#line 167 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                 foreach (var item in Model.Tags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd34161", async() => {
#nullable restore
#line 169 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 169 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 170 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            ");
#nullable restore
#line 173 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
       Write(Html.ValidationMessageFor(model => model.Game.Tags, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>

    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <button type=""submit"" class=""btn btn-primary"">Dodaj</button>
            <a href=""#"" class=""btn btn-secondary"" onclick=""javascript:window.history.back(-1);return false;"">Powrót</a>

        </div>
    </div>
</div>
");
#nullable restore
#line 185 "D:\PRO_Core\PRO\PRO\Views\Games\Add.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js""></script>
<script language=""javascript"" type=""text/javascript"">

    function GetImagesByType(_stateId) {
        var procemessage = ""<option value='0'> Please wait...</option>"";
        $(""#ImageId"").html(procemessage).show();
        var url = ""/images/getimagesbytype/"" + _stateId;

        $.ajax({
            url: url,
            data: { id: _stateId },
            cache: false,
            type: ""POST"",
            success: function (data) {
                if (data.length > 0) {
                    var markup = ""<option value=\""0\"">Wybierz obrazek</option>"";
                } else {
                    var markup = ""<option value=\""0\"">Brak obrazków wybranego typu</option>"";
                }

                for (var x = 0; x < data.length; x++) {
                    markup += ""<option value="" + data[x].value + "">"" + data[x].text + ""</option>"";
                }
                $(""#ImageId"").html(m");
            WriteLiteral(@"arkup).show();
                $('#ImageId').selectpicker(""refresh"");
            },
            error: function (reponse) {
                alert(""error : "" + reponse);
            }
        });

    }


</script>
<script>
    function SetImageId() {
        var id = $('#ImageId').find("":selected"").Value;
        console.log(id);
    }
</script>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "185bb79cf53f81d47df37a4a52c8e42c58c2e5fd38429", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.GameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
