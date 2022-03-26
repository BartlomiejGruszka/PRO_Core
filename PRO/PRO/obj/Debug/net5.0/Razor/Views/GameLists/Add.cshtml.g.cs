#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452dfb66f1d8eb4d5698dfb182ac1e2e4901bb66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameLists_Add), @"mvc.1.0.view", @"/Views/GameLists/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452dfb66f1d8eb4d5698dfb182ac1e2e4901bb66", @"/Views/GameLists/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_GameLists_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.GameList>
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
#nullable restore
#line 3 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2 class=\"list-title box-shadow\">Dodaj grę do listy użytkownika</h2>\r\n<div class=\"window-background box-shadow p-3\">\r\n");
#nullable restore
#line 11 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n\r\n            ");
#nullable restore
#line 17 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
       Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 20 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
           Write(Html.LabelFor(model => model.UserList.UserId, "Użytkownik", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-10"">
                    <select class=""selectpicker show-tick"" style=""max-width:400px;"" id=""UserList.UserId"" name=""UserList.UserId"" data-live-search=""true"" title=""Wybierz użytkownika"" onchange=""javascript:GetUserLists(this.value);"" required>
");
#nullable restore
#line 23 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                         foreach (var item in ViewBag.userList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452dfb66f1d8eb4d5698dfb182ac1e2e4901bb665463", async() => {
#nullable restore
#line 25 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                                                Write(item.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
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
#line 26 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </select>\r\n                    <div>");
#nullable restore
#line 29 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                    Write(Html.ValidationMessageFor(model => model.UserList.UserId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 33 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
           Write(Html.LabelFor(model => model.UserListId, "Lista użytkownika", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""col-md-10"">
                    <select class=""selectpicker show-tick"" style=""max-width:400px;"" id=""UserListId"" name=""UserListId"" data-live-search=""true"" onchange=""SetListId()"" title=""Wybierz listę"" required>
                    </select>
                    <div>");
#nullable restore
#line 37 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                    Write(Html.ValidationMessageFor(model => model.UserListId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
           Write(Html.LabelFor(model => model.GameId, "Gra", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <select class=\"selectpicker show-tick\" style=\"max-width:400px;\" id=\"GameId\" name=\"GameId\" data-live-search=\"true\" title=\"Wybierz grę\" required>\r\n");
#nullable restore
#line 44 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                         foreach (var item in ViewBag.Games)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452dfb66f1d8eb4d5698dfb182ac1e2e4901bb669643", async() => {
#nullable restore
#line 46 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
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
#line 46 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
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
#line 47 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </select>\r\n                    <div>");
#nullable restore
#line 50 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
                    Write(Html.ValidationMessageFor(model => model.GameId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 54 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
           Write(Html.LabelFor(model => model.HoursPlayed, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 56 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
               Write(Html.EditorFor(model => model.HoursPlayed, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 57 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.HoursPlayed, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 62 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
           Write(Html.LabelFor(model => model.PersonalScore, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 64 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
               Write(Html.EditorFor(model => model.PersonalScore, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 65 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
               Write(Html.ValidationMessageFor(model => model.PersonalScore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
#line 76 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<script src=""http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js""></script>
<script language=""javascript"" type=""text/javascript"">
    function GetUserLists(_stateId) {
        var procemessage = ""<option value='0'> Please wait...</option>"";
        $(""#UserListId"").html(procemessage).show();
        var url = ""getuserlists/"" + _stateId;

        $.ajax({
            url: url,
            data: { id: _stateId },
            cache: false,
            type: ""POST"",
            success: function (data) {
                if (data.length > 0) {
                    var markup = ""<option value=\""0\"">Wybierz listę użytkownika</option>"";
                } else {
                    var markup = ""<option value=\""0\"">Użytkownik nie ma list</option>"";
                }

                for (var x = 0; x < data.length; x++) {
                    markup += ""<option value="" + data[x].value + "">"" + data[x].text + ""</option>"";
                }
                $(""#UserListId"").html(");
            WriteLiteral(@"markup).show();
                $('#UserListId').selectpicker(""refresh"");
            },
            error: function (reponse) {
                alert(""error : "" + reponse);
            }
        });

    }

</script>

<script>
    function SetListId() {
        var id = $('#UserListId').find("":selected"").Value;
        console.log(id);
    }
</script>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "452dfb66f1d8eb4d5698dfb182ac1e2e4901bb6616178", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.GameList> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
