#pragma checksum "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f500d8f12eefe0b1a8412cd5797eba98a7f929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameLists_Edit), @"mvc.1.0.view", @"/Views/GameLists/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f500d8f12eefe0b1a8412cd5797eba98a7f929", @"/Views/GameLists/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_GameLists_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.GameList>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edytuj grę na liście użytkownika</h2>\r\n\r\n");
#nullable restore
#line 10 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
   Write(Html.HiddenFor(model => model.AddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
   Write(Html.HiddenFor(model => model.UserListId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
       Write(Html.LabelFor(model => model.HoursPlayed, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 23 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.EditorFor(model => model.HoursPlayed, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.HoursPlayed, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 29 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
       Write(Html.LabelFor(model => model.PersonalScore, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 31 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.EditorFor(model => model.PersonalScore, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.PersonalScore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 37 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
       Write(Html.LabelFor(model => model.UserList.UserId, "Użytkownik", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 39 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.DropDownListFor(m => m.UserList.UserId, new List<SelectListItem> { }, Model.UserList.User.UserName, new { @class = "form-control", @disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 43 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
       Write(Html.LabelFor(model => model.UserListId, "Lista użytkownika", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 45 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.DropDownListFor(m => m.UserListId, new SelectList(ViewBag.userLists, "Id", "Name"), "Wybierz listę użytkownika", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.UserListId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 50 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
       Write(Html.LabelFor(model => model.GameId, "Gra", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 52 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.DropDownListFor(m => m.GameId, new SelectList(ViewBag.Games, "Id", "Title"), "Wybierz grę", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 53 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.GameId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Zapisz"" class=""btn btn-primary"" />
                <a href=""#"" class=""btn btn-secondary"" onclick=""javascript:window.history.back(-1);return false;"">Powrót</a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 64 "D:\PRO_Core\PRO\PRO\Views\GameLists\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js""></script>
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
                    var markup = ""<option value='0'>Wybierz listę użytkownika</option>"";
                } else {
                    var markup = ""<option value='0'>Użytkownik nie ma list</option>"";
                }

                for (var x = 0; x < data.length; x++) {
                    markup += ""<option value="" + data[x].Value + "">"" + data[x].Text + ""</option>"";
                }
                $(""#UserListId"").html(markup).show");
            WriteLiteral(@"();
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54f500d8f12eefe0b1a8412cd5797eba98a7f92911875", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.GameList> Html { get; private set; }
    }
}
#pragma warning restore 1591