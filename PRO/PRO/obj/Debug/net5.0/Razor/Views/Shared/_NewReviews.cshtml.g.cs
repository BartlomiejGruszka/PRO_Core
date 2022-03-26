#pragma checksum "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85c1c633c8dd1b12b818986049dbf8d7693fc306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NewReviews), @"mvc.1.0.view", @"/Views/Shared/_NewReviews.cshtml")]
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
#nullable restore
#line 2 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
using PRO.Domain.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c1c633c8dd1b12b818986049dbf8d7693fc306", @"/Views/Shared/_NewReviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf9f3a3aa24260c90f9edb8910125fa82e0c97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__NewReviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PRO.Entities.Review>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
  string StripHTML(string input, int length)
    {
        if (!string.IsNullOrEmpty(input))
        {
            input = Regex.Replace(input, "<.*?>", String.Empty);
            input = Regex.Replace(input, "&nbsp;", " ");
            input = input.Truncate(length);
            return input;
        }
        else
        {
            return "";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"side-list-group\">\r\n    <h3 class=\"sidebar-title list-title box-shadow\">Najnowsze recenzje</h3>\r\n");
#nullable restore
#line 23 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
       var reviews = Model.ToList();
        if (reviews.Any())
        {
            for (var i = 0; i < 3; i++)
            {
                if (reviews.ElementAtOrDefault(i) != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 851, "\"", 906, 4);
            WriteAttributeValue("", 858, "/games/", 858, 7, true);
#nullable restore
#line 30 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
WriteAttributeValue("", 865, reviews[i].GameId, 865, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 883, "/reviews/", 883, 9, true);
#nullable restore
#line 30 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
WriteAttributeValue("", 892, reviews[i].Id, 892, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action flex-column align-items-start box-shadow\">\r\n\r\n                            <div class=\"d-flex w-100 justify-content-between\">\r\n                                <h5 class=\"mb-1\">");
#nullable restore
#line 33 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
                                            Write(reviews[i].Game.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n\r\n                            <p class=\"mb-1\" style=\"font-weight:400;\">\r\n");
#nullable restore
#line 37 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
                                   var content = @StripHTML(reviews[i].Content, 120);
                                    if (content.Length == 120)
                                    {
                                        content = content + "...";
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 43 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
                           Write(Html.Raw(content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                            </p>\r\n\r\n\r\n\r\n                            <small");
            BeginWriteAttribute("class", " class=\"", 1863, "\"", 1871, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
                                       Write(reviews[i].User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 52 "E:\Repo_PRO\PRO\PRO\Views\Shared\_NewReviews.cshtml"
                }

            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PRO.Entities.Review>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
