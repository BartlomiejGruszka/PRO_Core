#pragma checksum "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de240b3f2ae60cf4d8dbf1bfc4e869fe2db9800e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AddGameToUserList__AddGameToUserList), @"mvc.1.0.view", @"/Views/Shared/Components/AddGameToUserList/_AddGameToUserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de240b3f2ae60cf4d8dbf1bfc4e869fe2db9800e", @"/Views/Shared/Components/AddGameToUserList/_AddGameToUserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AddGameToUserList__AddGameToUserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.GameList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
 using (Html.BeginForm("AddGameToList", "GameLists", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
Write(Html.HiddenFor(model => model.AddedDate, new { Value = Model.AddedDate }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input data-val=\"true\" data-val-required=\"The Int32 field is required.\" id=\"GameId\" name=\"GameId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 385, "\"", 408, 1);
#nullable restore
#line 8 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
WriteAttributeValue("", 393, ViewBag.GameId, 393, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input data-val=\"true\" data-val-required=\"The Int32 field is required.\" id=\"Id\" name=\"Id\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 519, "\"", 538, 1);
#nullable restore
#line 9 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
WriteAttributeValue("", 527, ViewBag.Id, 527, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 13 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 16 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
       Write(Html.LabelFor(model => model.HoursPlayed, htmlAttributes: new { @class = "control-label col-md-2", @style = "display: inline; " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 18 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
           Write(Html.EditorFor(model => model.HoursPlayed, new { htmlAttributes = new { @class = "form-control", @min = "0", @max = "99999" ,@Value = "0"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
           Write(Html.ValidationMessageFor(model => model.HoursPlayed, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 24 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
       Write(Html.LabelFor(model => model.PersonalScore, htmlAttributes: new { @class = "control-label col-md-2", @style = "display: inline; " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 26 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
           Write(Html.EditorFor(model => model.PersonalScore, new { htmlAttributes = new { @class = "form-control", @min = "0", @max = "10" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
           Write(Html.ValidationMessageFor(model => model.PersonalScore, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
       Write(Html.LabelFor(model => model.UserListId, "Lista u??ytkownika", htmlAttributes: new { @class = "control-label col-md-2", @style = "display: inline; " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 33 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
           Write(Html.DropDownListFor(model=>model.UserListId,new SelectList(ViewBag.UserListId, "Id", "Name"), "Wybierz list??", htmlAttributes: new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
           Write(Html.ValidationMessageFor(model => model.UserListId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Zapisz\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 42 "D:\PRO_Core\PRO\PRO\Views\Shared\Components\AddGameToUserList\_AddGameToUserList.cshtml"
    
}

#line default
#line hidden
#nullable disable
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
