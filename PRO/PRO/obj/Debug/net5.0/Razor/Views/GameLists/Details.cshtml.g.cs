#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa5dce0a197f635c7f197e0806a0688c86216b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameLists_Details), @"mvc.1.0.view", @"/Views/GameLists/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffa5dce0a197f635c7f197e0806a0688c86216b9", @"/Views/GameLists/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_GameLists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.GameList>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2 class=""list-title box-shadow"">Szczegóły gry na liście użytkownika</h2>
<div class=""window-background box-shadow p-3"">
    <div>

        <dl class=""dl-horizontal"">
            <dt>
                Użytkownik
            </dt>

            <dd>
                ");
#nullable restore
#line 19 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayFor(model => model.UserList.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 23 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Game.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 27 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayFor(model => model.Game.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 31 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UserList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 35 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayFor(model => model.UserList.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 39 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.HoursPlayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 43 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayFor(model => model.HoursPlayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 47 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PersonalScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 51 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayFor(model => model.PersonalScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 54 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 58 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayFor(model => model.AddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 61 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.EditedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 65 "E:\Repo_PRO\PRO\PRO\Views\GameLists\Details.cshtml"
           Write(Html.DisplayFor(model => model.EditedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
    <hr />
    <p>
        <div class=""form-actions no-color"">
            <input type=""submit"" value=""Usuń"" class=""btn btn-primary"" />
            <a href=""#"" class=""btn btn-secondary"" onclick=""javascript:window.history.back(-1);return false;"">Powrót</a>
        </div>
    </p>
</div>");
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
