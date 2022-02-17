#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b0665e6377cf60d09368389c2fa87270ad1f767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_ManageDetails), @"mvc.1.0.view", @"/Views/Articles/ManageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b0665e6377cf60d09368389c2fa87270ad1f767", @"/Views/Articles/ManageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_ManageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRO.Entities.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
  
    ViewBag.Title = "ManageDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"list-title box-shadow\">Szczegóły artykułu</h2>\r\n<div class=\"window-background box-shadow p-3\">\r\n    <div>\r\n\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
#nullable restore
#line 14 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 18 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 21 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Game));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 25 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Game.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 28 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.ArticleType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 32 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.ArticleType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 36 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Author.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 40 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Author.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 43 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Author.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 47 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.Author.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 50 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 54 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 57 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 61 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 64 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n\r\n");
#nullable restore
#line 69 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
                  if (Model.Image != null)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div style=\"text-align: left;\">\r\n                            <img style=\"max-height:200px;max-width:100px;width: expression(this.width > 100 ? 100: true);\" class=\" lazyloaded\"");
            BeginWriteAttribute("src", " src=\"", 2106, "\"", 2142, 2);
            WriteAttributeValue("", 2112, "/images/", 2112, 8, true);
#nullable restore
#line 73 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
WriteAttributeValue("", 2120, Model.Image.ImagePath, 2120, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 75 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Brak obrazu</p>");
#nullable restore
#line 77 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
                                        }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 83 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Preview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 87 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.Raw(@Model.Preview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 90 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 94 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.Raw(@Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n                ");
#nullable restore
#line 98 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.SourceLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n                ");
#nullable restore
#line 102 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
           Write(Html.DisplayFor(model => model.SourceLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n    <hr />\r\n    <p>\r\n        <div class=\"btn btn-primary\"><a class=\"actionLinkManage\"");
            BeginWriteAttribute("href", " href=\"", 2992, "\"", 3023, 2);
            WriteAttributeValue("", 2999, "/articles/edit/", 2999, 15, true);
#nullable restore
#line 109 "E:\Repo_PRO\PRO\PRO\Views\Articles\ManageDetails.cshtml"
WriteAttributeValue("", 3014, Model.Id, 3014, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a></div>\r\n        <a href=\"#\" class=\"btn btn-secondary\" onclick=\"javascript:window.history.back(-1);return false;\">Powrót</a>\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRO.Entities.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
