#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "169c258bc84c89808ba148a116f4b26198c9abeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Edit), @"mvc.1.0.view", @"/Views/Users/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169c258bc84c89808ba148a116f4b26198c9abeb", @"/Views/Users/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.UI.ViewModels.EditUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
  
    ViewBag.Title = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2 class=\"list-title box-shadow\">Edytuj użytkownika</h2>\r\n<div class=\"window-background box-shadow p-3\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 203, "\"", 211, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
         using (Html.BeginForm("Edit", "Users", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
       Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
       Write(Html.HiddenFor(model => model.AppUser.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"underlined_h2\">Podstawowe informacje</h3>\r\n            <br />\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 20 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(m => m.AppUser.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 22 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.TextBoxFor(m => m.AppUser.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.AppUser.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(m => m.AppUser.UserName, "Nazwa użytkownika", new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.TextBoxFor(m => m.AppUser.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.AppUser.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(model => model.AppUser.RegisterDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 36 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(model => model.AppUser.RegisterDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.AppUser.RegisterDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(model => model.AppUser.IsActive, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"checkbox\">\r\n                        ");
#nullable restore
#line 44 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                   Write(Html.EditorFor(model => model.AppUser.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.AppUser.IsActive, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <h3 class=\"underlined_h2\">Dodatkowe informacje</h3>\r\n            <br />\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(model => model.AppUser.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 55 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.TextAreaFor(model => model.AppUser.Description, new { @id = "mytextarea", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 56 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.AppUser.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 60 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(model => model.ImageTypes, "Rodzaj obrazka", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-10"">
                    <select class=""selectpicker show-tick"" style=""max-width:400px;"" id=""SelectedImageTypeId"" name=""SelectedImageTypeId"" data-live-search=""true"" onchange=""javascript:GetImagesByType(this.value);"" title=""Wybierz rodzaj obrazka"">
");
#nullable restore
#line 63 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                         foreach (var item in Model.ImageTypes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "169c258bc84c89808ba148a116f4b26198c9abeb11320", async() => {
#nullable restore
#line 65 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
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
#line 65 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
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
#line 66 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 72 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(model => model.AppUser.ImageId, "Obraz", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-10"">
                    <select class=""selectpicker show-tick"" style=""max-width:400px;"" id=""ImageId"" name=""AppUser.ImageId"" data-live-search=""true"" onchange=""SetImageId()"" title=""Wybierz obraz"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "169c258bc84c89808ba148a116f4b26198c9abeb13944", async() => {
                WriteLiteral("Brak");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 76 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                         if (Model.AppUser.Image != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "169c258bc84c89808ba148a116f4b26198c9abeb15372", async() => {
#nullable restore
#line 78 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                                                                       Write(Model.AppUser.Image.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                                        WriteLiteral(Model.AppUser.ImageId);

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
#line 79 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </select>\r\n                    ");
#nullable restore
#line 82 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.AppUser.ImageId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 87 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
           Write(Html.LabelFor(model => model.AppUser.IsPublic, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"checkbox\">\r\n                        ");
#nullable restore
#line 90 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                   Write(Html.EditorFor(model => model.AppUser.IsPublic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 91 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
                   Write(Html.ValidationMessageFor(model => model.AppUser.IsPublic, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <hr />
            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-12"">
                    <input type=""submit"" class=""btn btn-primary"" value=""Zapisz"" />
                    <a href=""#"" class=""btn btn-secondary"" onclick=""javascript:window.history.back(-1);return false;"">Powrót</a>
                </div>
            </div>
");
#nullable restore
#line 102 "D:\PRO_Core\PRO\PRO\Views\Users\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
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
                ");
            WriteLiteral(@"$(""#ImageId"").html(markup).show();
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "169c258bc84c89808ba148a116f4b26198c9abeb21284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.UI.ViewModels.EditUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
