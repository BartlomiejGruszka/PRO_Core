#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1b57abd9c4fe71d135817016db91930536cb74e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Add), @"mvc.1.0.view", @"/Views/Articles/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b57abd9c4fe71d135817016db91930536cb74e", @"/Views/Articles/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Articles_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.ArticleViewModel>
    #nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
  
    ViewBag.Title = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"list-title box-shadow\">Dodaj artykuł</h2>\r\n<div class=\"window-background box-shadow p-3\">\r\n\r\n");
#nullable restore
#line 11 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
     using (Html.BeginForm("Add", "Articles"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n\r\n\r\n            ");
#nullable restore
#line 18 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
       Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <h3 class=\"underlined_h2\">Podstawowe informacje</h3>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 21 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.GameId, "Gra", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <select class=\"selectpicker show-tick\" style=\"max-width:400px;\" id=\"Article.GameId\" name=\"Article.GameId\" data-live-search=\"true\" title=\"Wybierz grę\" required>\r\n");
#nullable restore
#line 24 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                         foreach (var item in Model.Games)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b57abd9c4fe71d135817016db91930536cb74e5495", async() => {
#nullable restore
#line 26 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
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
#line 27 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </select>\r\n                    <div>");
#nullable restore
#line 30 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                    Write(Html.ValidationMessageFor(model => model.Article.GameId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 34 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 36 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.EditorFor(model => model.Article.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Article.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.Preview, htmlAttributes: new { @class = "control-label col-md-2 formtextarea" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 43 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.TextAreaFor(model => model.Article.Preview, new { @id = "formtextarea", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Article.Preview, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 48 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.Content, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 50 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.TextAreaFor(model => model.Article.Content, new { @id = "mytextarea", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 51 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Article.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 55 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.ArticleTypeId, "Rodzaj artykułu", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <select class=\"selectpicker show-tick\" style=\"max-width:400px;\" id=\"Article.ArticleTypeId\" name=\"Article.ArticleTypeId\" data-live-search=\"true\" title=\"Wybierz rodzaj artykułu\" required>\r\n");
#nullable restore
#line 58 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                         foreach (var item in Model.ArticleTypes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b57abd9c4fe71d135817016db91930536cb74e11882", async() => {
#nullable restore
#line 60 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
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
#line 60 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
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
#line 61 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </select>\r\n                    <div>");
#nullable restore
#line 64 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                    Write(Html.ValidationMessageFor(model => model.Article.ArticleTypeId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n\r\n            <br />\r\n            <h3 class=\"underlined_h2\">Dodatkowe informacje</h3>\r\n            <br />\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 72 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.SourceLink, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 74 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.EditorFor(model => model.Article.SourceLink, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 75 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Article.SourceLink, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 79 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.ImageTypes, "Rodzaj obrazka", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-10"">
                    <select class=""selectpicker show-tick"" style=""max-width:400px;"" id=""SelectedImageTypeId"" name=""SelectedImageTypeId"" data-live-search=""true"" onchange=""javascript:GetImagesByType(this.value);"" title=""Wybierz rodzaj obrazka"">
");
#nullable restore
#line 82 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                         foreach (var item in Model.ImageTypes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b57abd9c4fe71d135817016db91930536cb74e16321", async() => {
#nullable restore
#line 84 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
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
#line 84 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
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
#line 85 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 91 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.ImageId, "Obraz", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-10"">
                    <select class=""selectpicker show-tick"" style=""max-width:400px;"" id=""ImageId"" name=""Article.ImageId"" data-live-search=""true"" onchange=""SetImageId()"" title=""Wybierz obraz"">
                    </select>
                    ");
#nullable restore
#line 95 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.Article.ImageId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 99 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
           Write(Html.LabelFor(model => model.Article.IsActive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"checkbox\">\r\n                        ");
#nullable restore
#line 102 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                   Write(Html.EditorFor(model => model.Article.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 103 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Article.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <hr />
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Dodaj"" class=""btn btn-primary"" />
                    <a href=""#"" class=""btn btn-secondary"" onclick=""javascript:window.history.back(-1);return false;"">Powrót</a>
                </div>
            </div>
        </div>
");
#nullable restore
#line 115 "E:\Repo_PRO\PRO\PRO\Views\Articles\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js""></script>
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
                $(""#ImageId""");
            WriteLiteral(@").html(markup).show();
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1b57abd9c4fe71d135817016db91930536cb74e22526", async() => {
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.ArticleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
